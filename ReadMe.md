# Raindrops



## Objective

Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors:

- if the number has a factor of 3, output `Pling`
- if the number has a factor of 5, output `Plang`
- if the number has a factor of 7, output `Plong`
- if the number does not have any of the above as a factor simply return the numbers digits



## Examples

- Given the input 28
	-  The factors are 1, 2, 4, **7**, 14 and 28
	-   return  `Plong`
- Given the input 30
	-  The factors are 1, 2, **3**, **5**, 6, 10, 15, 30
	-   return `PlingPlang`
- Given the input 105
	-  The Factors are 1, **3**, **5**, **7**, 15, 21, 35,105
	-  return `PlingPlangPlong`
- Given the input 34
	- The factors are 1, 2, 17, and 34
	-  return `34`



## Testing

For the creation of this project TDD (Test-driven Development) was used. TDD is an approach to software development where you write tests first, then use those tests to drive the design and development of your software application. 	

The c# code block below shows you the structure of the tests.

```c#
[TestCase(-33)]
[TestCase(-3)]
[TestCase(6)]
[TestCase(12)]
public void GivenThatTheNumberHasAFactorOf3_ThenReturnPling(int number)
{
    var result = _rdLibrary.PlingPlangPlong(number);
    Assert.That(result, Is.EqualTo("Pling"));
}

```

A test can have several `[TestCase]` attributes, which can be used by the a test method to test multiple inputs.

The test method has been written in gherkin syntax with the syntax structure of:

**Given** - test step that defines the context

**Then** -  test step that defines the outcome



## Conditional Statement

To check if a requirement is met for the function I have used an IF statement. 

```c#
if (num % 3 == 0)
{
    result.Append("Pling");
}
```

The c# code block above shows you the structure of one of the IF statements. If a given `num` is divisible by 3, then the result will be appended to a string builder.





