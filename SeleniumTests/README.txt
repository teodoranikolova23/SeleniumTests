
## Test URL

Tests run against: `https://the-internet.herokuapp.com/`

## Features

- **Automatic driver management**: WebDriverManager automatically downloads and configures the appropriate ChromeDriver version
- **Clean abstractions**: IBrowser and IElement interfaces enable testability and maintainability
- **Page Object Model**: Separates page structure from test logic for better organization
- **Proper resource cleanup**: Ensures browser instances are properly disposed after tests

## Contributing

1. Create a new branch for your feature
2. Implement tests following the existing patterns
3. Ensure all tests pass
4. Submit a pull request

## Future Enhancements

- Add support for multiple browsers (Firefox, Edge, Safari)
- Implement explicit wait mechanisms in SeleniumElement
- Add reporting and screenshot capture on test failure
- Extend IElement implementation with more interaction methods
- Add configuration file for test URLs and timeouts



## Authors

[Teodora Nikokolova]