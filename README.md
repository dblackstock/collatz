# Collatz Repository

C# app to run numbers through the Collatz Conjecture

## What is the Collatz Conjecture?

The Collatz Conjecture (or the `3n + 1` problem, or several other names) is the prediction that every positive number will reach 1 when it goes through the following algorithm:

If the number `n` is odd, perform `3n+1`;
If the number `n` is even, perform `n/2`.

This program takes in a number and checks that it reaches 1. It also records the "stopping time" of the number - the number of steps it takes for the number to reach 1. For example, 5 progresses through the algorithm like 5, 16, 8, 4, 2, 1. 5 therefore has a stopping time of 5.

## Building and running

The code has been built with `dotnet build --configuration release -r linux-arm64`. It should be possible to run it by loading the `bin/release/net5.0/linux-arm64` directory onto an AWS EC2 instance and then running `dotnet run`.
