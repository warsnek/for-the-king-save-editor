using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;

namespace ForTheKingSaveEdit
{
  /// <summary>
  ///   Parser for command line arguments. Supports different kinds of arguments:
  ///   -param1 value1 --param2 /param3:"Test-:-work" /param4=happy -param5 '--=nice=--'
  /// </summary>
  [ExcludeFromCodeCoverage]
  public class ArgumentsParser
  {
    private static readonly Regex _spliter = new Regex(@"^-{1,2}|^/|=|:",
      RegexOptions.IgnoreCase | RegexOptions.Compiled, TimeSpan.FromSeconds(3));

    private static readonly Regex _remover = new Regex(@"^['""]?(.*?)['""]?$",
      RegexOptions.IgnoreCase | RegexOptions.Compiled, TimeSpan.FromSeconds(3));

    private readonly Dictionary<string, string> _parameters =
      new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    ///   Create a <see cref="ArgumentsParser" /> class with the commandline arguments
    /// </summary>
    /// <param name="args">The arguments.</param>
    public ArgumentsParser(IEnumerable<string> args)
    {
      string parameter = null;

      // Valid parameters forms:
      // {-,/,--}param{ ,=,:}((",')value(",'))
      // Examples: -param1 value1 --param2 /param3:"Test-:-work" /param4=happy -param5 '--=nice=--'
      foreach (string txt in args)
      {
        // Look for new parameters (-,/ or --) and a possible enclosed value (=,:)
        string[] parts = _spliter.Split(txt, 3);

        switch (parts.Length)
        {
          // Found a value (for the last parameter found (space separator))
          case 1:
            if (parameter != null)
            {
              if (!_parameters.ContainsKey(parameter))
              {
                parts[0] = _remover.Replace(parts[0], "$1");
                _parameters.Add(parameter, parts[0]);
              }
              parameter = null;
            }
            // else Error: no parameter waiting for a value (skipped)
            break;
          // Found just a parameter
          case 2:
            // The last parameter is still waiting. With no value, set it to null.
            if (parameter != null)
            {
              if (!_parameters.ContainsKey(parameter))
              {
                _parameters.Add(parameter, null);
              }
            }
            parameter = parts[1];
            break;
          // Parameter with enclosed value
          case 3:
            // The last parameter is still waiting. With no value, set it to null.
            if (parameter != null)
            {
              if (!_parameters.ContainsKey(parameter))
              {
                _parameters.Add(parameter, null);
              }
            }
            parameter = parts[1];
            // Remove possible enclosing characters (",')
            if (!_parameters.ContainsKey(parameter))
            {
              parts[2] = _remover.Replace(parts[2], "$1");
              _parameters.Add(parameter, parts[2]);
            }
            parameter = null;
            break;
        }
      }
      // In case a parameter is still waiting, set it to null.
      if (parameter != null)
      {
        if (!_parameters.ContainsKey(parameter))
        {
          _parameters.Add(parameter, null);
        }
      }
    }

    /// <summary>
    ///   Checks whether one or more arguments are provided at the command line.
    /// </summary>
    /// <param name="arguments">The arguments.</param>
    /// <returns>
    ///   True if one or more arguments exists, else false.
    /// </returns>
    public bool ContainsArgument(params string[] arguments)
    {
      return arguments.Any(a => _parameters.ContainsKey(a));
    }

    /// <summary>
    ///   Tries to retrieve an argument value.
    /// </summary>
    /// <param name="argument"> The argument to check. </param>
    /// <param name="value"> The value of the argument. </param>
    /// <returns> True is the argument exists, else false. </returns>
    public bool TryGetValue(string argument, out string value)
    {
      return _parameters.TryGetValue(argument, out value);
    }

    /// <summary>
    ///   Retrieve the value of a argument. Is no value found then returns null.
    /// </summary>
    /// <param name="argument"> The argument to return the value from. </param>
    /// <returns> The value if a value as provided, null if no value was provided. </returns>
    /// <exception cref="System.ArgumentNullException">key is null.</exception>
    /// <exception cref="System.Collections.Generic.KeyNotFoundException">The key does not exist in the collection.</exception>
    public string this[string argument]
    {
      get
      {
        if (_parameters.ContainsKey(argument))
        {
          return _parameters[argument];
        }
        return null;
      }
    }

    /// <summary>
    /// Gets the value of the specified argument, with optional default fallback value.
    /// </summary>
    /// <param name="argument">The argument.</param>
    /// <param name="defaultValue">The default fallback value.</param>
    /// <returns></returns>
    public string Get(string argument, string defaultValue = null)
    {
      if (TryGetValue(argument, out var result))
      {
        return result;
      }
      return defaultValue;
    }

    /// <summary>
    ///   Returns the number of parsed arguments.
    /// </summary>
    public int Count => _parameters.Count;
  }
}