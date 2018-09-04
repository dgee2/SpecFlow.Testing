Feature: SmokeTest

Scenario Outline: I make a simple http method request
When I make a <Method> request to the <Url> url
Scenarios: 
	| Method | Url                                          |
	| GET    | https://jsonplaceholder.typicode.com/todos/1 |
	| POST   | https://jsonplaceholder.typicode.com/todos/1 |
	| PUT    | https://jsonplaceholder.typicode.com/todos/1 |
	| PATCH  | https://jsonplaceholder.typicode.com/todos/1 |
	| DELETE | https://jsonplaceholder.typicode.com/todos/1 |

Scenario Outline: I make a simple http method request from config
When I make a <Method> request to the ApiUrl url from config
Scenarios: 
	| Method |
	| GET    |
	| POST   |
	| PUT    |
	| PATCH  |
	| DELETE |

Scenario: I validate the response of a GET request is valid Json
When I make a GET request to the ApiUrl url from config
Then The request response is valid Json

Scenario: I validate the response of a GET request contains a specific key in the response
When I make a GET request to the TodosApiUrl url from config
Then the key $[1].title in the response exists

Scenario: I validate the response of a GET request contains a specific count of elements
When I make a GET request to the TodosApiUrl url from config
Then the key $ in the response contains 200 elements

Scenario: I validate the response of a GET request contains the correct integer
When I make a GET request to the TodosApiUrl url from config
Then the key $[30].userId in the response equals the integer 2

Scenario: I validate the response of a GET request contains an integer greater than
When I make a GET request to the TodosApiUrl url from config
Then the key $[30].userId in the response is greater than the integer 1

Scenario: I validate the response of a GET request contains an integer greater than or equal to
When I make a GET request to the TodosApiUrl url from config
Then the key $[30].userId in the response is greater than or equal to the integer 1
Then the key $[30].userId in the response is greater than or equal to the integer 2

Scenario: I validate the response of a GET request contains an integer less than
When I make a GET request to the TodosApiUrl url from config
Then the key $[30].userId in the response is less than the integer 3

Scenario: I validate the response of a GET request contains an integer less than or equal to
When I make a GET request to the TodosApiUrl url from config
Then the key $[30].userId in the response is less than or equal to the integer 2
Then the key $[30].userId in the response is less than or equal to the integer 3

Scenario: I validate the response of a GET request contains the correct string
When I make a GET request to the TodosApiUrl url from config
Then the key $[105].title in the response equals the string ad illo quis voluptatem temporibus

