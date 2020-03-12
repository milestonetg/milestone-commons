# Change Log

## [3.0.0]

### Added

- `ICurrentDateTime` and `DefaultCurrentDateTime` to facilitate unit testing with `System.DateTime` and `System.DateTimeOffset`.

### Breaking Changes

There are several breaking changes in this release. It is recommended that you test your code thoroughly after updating.
A few are as follows:

- DataUtil.Convert() is now null-safe. Passing in null will return default.
- String.Parse() extension method has been renamed to String.ConvertTo().
