# Number Sequences Generator
This project is a web based application that is used to generate a variety of number sequences.

## Purpose

*Number Sequences Generator* is used to generate below number sequences by getting the upper limit of the sequences as an input from the user.

Below are the sequences that shall be generated from this application.

* `Simple Sequence`: All numbers up to and including the number entered.
* `Odd Numbers`: All odd numbers up to and including the number entered.
* `Even Numbers`: All even numbers up to and including the number entered.
* `Fobonacci Sequnce`: All fibonacci number up to and including the number entered.
* `Special Sequnce`: There will be one more special sequence that will be similar to Simple sequence. But the numbers that are divisible by 3 will be replaced by C, divisible by 3 will be replaced by E and divisible by both 3 and 5 will be replaced by Z.


## Technical Components:

* `Generator.Web` is the MVC web application that interacts with the user (UI module).
		* This appliaction has been extended to implement Web APIs and Angular JS. 
*  Note: Please modify the RouteConfig.cs file to redirect the home page appropriately. 
* `Generator.Business` is the library that contains the business logic.
* `Generator.Business.Tests` is the testing project that tests the business library.


## Database

No database is associated with this project.

## Installation

This is project is expected to be hosted as IIS (7.0 or later) based web application with .NET 4.0 and MVC5. Based on the later requirements, this project has been re-developed using Web APIs and Angular JS (1.x).

## Authors:

* **Arun Ramanantham**   10 October 2016

## Licensing

This project has an open license.
