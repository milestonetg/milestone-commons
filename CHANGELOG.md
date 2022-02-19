# Change Log

## [4.0.0]

### Added

- `Currency` struct for representing money in a domain.

### Breaking Changes

- Removed types and methods marked obsolete in 3.0.
- Changed the .Net Framework minimum target to net452 to stay inline with Microsoft's support cycle.

## [3.0.0]

### Added

- `ICurrentDateTime` and `DefaultCurrentDateTime` to facilitate unit testing with `System.DateTime` and `System.DateTimeOffset`.

### Breaking Changes

There are several breaking changes in this release. It is recommended that you test your code thoroughly after updating.
A few are as follows:

- DataUtil.Convert() is now null-safe. Passing in null will return default.
- String.Parse() extension method has been renamed to String.ConvertTo().
