# PPLWorkOut

The PPLWorkOut Program is designed to provide the user with a simple workout program based on either a push, pull, or leg routine. After a program is chosen, weights and exercises are listed based on the user's 1RM (1 rep max).

This solves the guesswork for planning a workout.

CodeLouisville project requirements:
- Project loaded to Github
- README with instructions for program
- Additional classes beyond the default program class with objects created from these classes
- Multiple types of functions/methods created with some returning a value to user
- Program features listed below:

Features:

Feature 1: Implements a "master loop" where the user can repeatedly enter commands/perform actions, including choosing to exit the program.

Feature 2: Additional classes that inherit one or more properties from its parent

Feature 3: Build a conversion tool that converts user input to another type and displays it/Calculate and display data based on an external
factor

Feature 4: Implement a log that records errors, invalid inputs, or other important events and writes them to a text file


Instructions:
1. Clone Project to local machine
2. Create dat file in same directory as program.cs called "WorkoutLog.dat". This is where the WorkoutLog will be created/stored.
3. Choose options 1, 2, or 3 for desired workout type (push, pull, legs).
4. Enter 1RM (1 rep max) for primary lift associated to workout type (bench press, deadlift, squat).
5. Choose number of desired workouts (1-3).
6. Workouts and weights are displayed to user.
7. At end of workout, user can choose to enter another workout (Y) or close the program (N).
8. WorkoutLog will be created at path chosen by user and can be viewed showing completed workouts with date/time.

Feature usage:
1. Master loop where user can enter a single or multiple workout options, or exit the program.
2. Multiple classes that inherit properties from general exercise parent class (Excercise.cs). The warmup property is shared among all the other primary exercises.
3. Weights and rep schemes are converted based on the user's 1RM to determine the user's working weights. This is data is calculated and displayed to the user.
4. Successful workouts are logged in stored in a text file where previous entries showing date/time can be viewed.


ToDo
1. Implement a null check after user inputs that will repeat the previous question.
2. Add a list/dictionary of exercises that can be viewed
