# Vector Atumation Practice

UI Automation of ESPN Portal using Specflow BDD and Selenium WebDriver

## Pre-Requisites
- Visual Studio
- .Net Core 6.0
- Specflow for Visual Studio - Makes feature files pretties and add new functionalities to Visual Studio

## Instructions
- Clone the repository and open the  VwectorTests.sln file
- Build the Solution
- Add the settings.runsettings file into Tests -> Configure Run Settings -> Select Solution Wide runsettings File (VS 2022)
- Run the tests using Test Explorer

You may also change the browser into runsettings in order to perform tests in a different browser.

Default is Chrome.

Current acceptable values are: 
- Chrome 
- Edge

```xml
    <TestRunParameters>
    <Parameter name="applicationUrl" value="http://www.espn.com" />
	<Parameter name="browser" value="Chrome" />	  
    </TestRunParameters>
```
