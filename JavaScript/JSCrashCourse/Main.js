//arrays of objects & JSON

const todos = [
  {
    id: 1,
    text: "take out trash",
    isDone: true
  },
  {
    id: 2,
    text: "meet saad ",
    isDone: false
  },
  {
    id: 3,
    text: "get groceries",
    isDone: true
  }
];

//filter
const todoCompleted = todos.filter(function(todo)
{
 return todo.isDone === true;
}).map(function(todo){   //chain on method
    return todo.text;
})

console.log(todoCompleted);

//map
const todoText = todos.map(function(todo)
{
 return todo.text;
});

todos.forEach (function(todo)
{
 console.log(`for each: ${todo.text}`);
});

console.log(todoText);

for (let i = 0; i <= 10; i++) {
  console.log(`For loop number ${i}`);
}

for (let todo of todos) {
  console.log(todo.text);
}

console.log(todos[1].text);

const todoJSON = JSON.stringify(todos);

console.log(todoJSON);

//object literals
const person = {
  firstName: "John",
  lastName: "Doe",
  age: 30,
  hobbies: ["music", "movies"],
  address: {
    street: "Main St",
    city: "Melbourne"
  }
};

console.log(person.address.city, person.lastName);

const {
  firstName,
  lastName,
  address: { city }
} = person;

console.log(firstName, lastName, city);

person.email = "john@email.com";

console.log(person);

//arrays
const fruits = ["apples", "oranges", "pears"];

fruits[3] = "banana";
fruits.push("mango");
fruits.pop();

console.log(Array.isArray(fruits));

console.log(fruits.indexOf("oranges"));

console.log(fruits);

//methods
const s = "Technology, IT, Computer";

console.log(s.split(", "));

//data types
//strings, numbers, boolean, null, undefined, symbol (ES6)
const name = "john";
const age = 37;

//Concatenation
console.log("my age is " + 37);

//Template String
const hello = `my name is ${name} & my age is ${37}`;
console.log(hello);

//let, Const

let score = 30;

score = 31;

console.log(score);
