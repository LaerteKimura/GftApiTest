# MealAPI

Test in C# - API of Meals

### Rules of test :
We are expecting to evaluate follow criteria:

1. Object Oriented Design
2. Respect SOLID Principles
3. Readability
4. Maintainability
5. Testability

### Backend Requirements:
1. Create this solution as a Web API application based on Swagger/RAML contract
2. Solution must have unit tests
3. Expose documentation via Swagger
4. Push your solution in a GitHub repository, and send us a link when done

## Usage
Use method GET with parameters on URI.

Put the parametes separated by ',' (comma) without spaces on request

Example: localhost:9494/api/MealRetur/night,1,2,3

## Return
Return is avaliable in json structure with a key called by "retorno" as sample shown below:

```json
[
    {
        "retorno": "eggs, toast, coffee, error"
    }
]
```

## Swagger

Use default URI for Swagger documentation.

Example: //localhost:9494/swagger/index.html

## Sample Input and Output:

Input  | Output
------------- | -------------
morning,1,2,3   | eggs, toast, coffee
morning,2,1,3  | eggs, toast, coffee
morning,1,2,3,4 | eggs, toast, coffee, error
morning,1,2,3,3,3 | eggs, toast, coffee(x3)
night,1,2,3,4 | steak, potato, wine, cake
night,1,2,2,4 | steak, potato(x2), cake
night,1,2,3,5 | steak, potato, wine, error
night,1,1,2,3,5 | steak, error
 
