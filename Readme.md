# Manual test
* Added manual test cases using bdd
* Usually I use my own excel based test case template

# Automation test
Used Xunit, SpecFlow and Selenium with C#. Created lighter version of framework 

## important points
* ISelect web site undergoing some maintanence or upgrade during the development time, there were 2 versions of web site opening randomly. 
* The test cases were created for 1 of the version, which may break if the new or 2nd version loaded
* I've uploaded video as a test evidence
* Test results also uploaded

* I have used Thread.Sleep in multiple places to keep it simple, I usually use other patterns instead of static wait
* Currently tests are sequential, can be easily upgraded to parallel execution


## how to run the tests?
```
dotnet test
```