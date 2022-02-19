# Milestone Commons Library

[![Build Status](https://milestonetg.visualstudio.com/Milestone/_apis/build/status/milestonetg.milestone-library?branchName=master)](https://milestonetg.visualstudio.com/Milestone/_build/latest?definitionId=40&branchName=master)

## What's New

A new `Currency` datatype for modeling currencies in a business domain.

For a list of all changes/updates in this release, view the [change log](https://github.com/milestonetg/milestone-commons/blob/master/CHANGELOG.md).

## Mocking DateTime in Unit Tests

One of the interfaces in commons is `ICurrentDateTime`. It's default implementation is `DefaultCurrentDateTime`.
It is recommended that this interface and factory be used when accessing the systems's current date/time. This allows
you to mock the date/time returned.

``` cs
public class MyService
{
    ICurrentDateTime datetimeFactory;
    public MyService(ICurrentDateTime datetimeFactory)
    {
        this.datetimeFactory = datetimeFactory;
    }

    public void dowork()
    {
        Datetime now = datetimeFactory.GetCurrentUtcDateTime();
        // do some work
    }
}
```

## Platform Targets

- NetStandard2.0
- Net452

## Building and Testing

Building from source and running unit tests requires a Windows machine with:

- .Net 6.0 SDK
- .Net Framework 4.5.2 Developer Pack

## Issues

Issues are tracked on [GitHub](https://github.com/milestonetg/milestone-commons/issues). Anyone is welcome to file a bug,
an enhancement request, or ask a general question. We ask that bug reports include:

1. A detailed description of the problem
2. Steps to reproduce
3. Expected results
4. Actual results
5. Version of the package
6. Version of the .Net runtime

## Contributing

Contributions are welcome! Please open an issue first so that your proposed changes can be discussed.

## License

Milestone Commons Library is licensed under the [MIT License](LICENSE).
