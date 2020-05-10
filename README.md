# eureka-moment-repls

Welcome to your pretest! We're hosting it on [repl.it](repl.it) because it handles low-level details like setting up your coding environment, auto-saving your progress, and letting you run your code easily.

## Quick Terminology

- integrated development environment (IDE): An all-in-one application that allows you to edit, compile, run, and debug code.
- fork: clone a github repository at a certain point, to allow you to safely make edits in your own environment.

## Getting Started

1. Navigate to the repl project.
2. Hit the `Files` icon on the upper left and switch to `Classes.cs`. This is the first problem you can work on.
3. When you edit a file for the first time, Repl.it will pause on a
   "saving" screen for a few moments. You'll also see few messages
   pop up at the bottom of the screen to let you know it's setting up a
   duplicate environment (called "forking"). When that is
   complete, you should be able to make edits without any issues.
   If the save screen is doesn't go away after a few minutes, just refresh the website. Let me know if you're having trouble editing files.

## Test Organization

The test is structured as a series of self-contained files, each corresponding with subproblems on a topic. For example, `Classes.cs` will contain all the necessary code to get you started on the section about classes. Errors in one program will not affect the results in other programs. Feel free to solve any of these questions in whatever order you choose. Look for comments titled `fixme` or `todo`, as they will indicate the lines of code you should change.

If you want to run each test individually, you can type in the following commands in the terminal:

```bash
PROBLEM=Classes # change this depending on which test you want to run.
csc $PROBLEM.cs && mono $PROBLEM.exe
```

If you want to run _all_ tests, just hit the "run" button at the top, or type in the following command:

```bash
bash main.sh
```

There are 6 sections to this test:
1. AlertService
2. BinarySearchTree
3. Classes
4. ControlFlowAndArrays
5. FreeResponses
6. MergeNames

## Submitting

When you're ready to submit:

0. Double check to ensure you've answered all [sections](#test-organization) for a list of all the sections).
1. Click "open in repl" in the upper right-hand corner. This will open a new tab.
2. At this point, please create a free account so your progress is permanently saved. Ignore any attempts to get you to sign up for premium.
3. Send me a link to this repl via Basecamp. It should have a format similar to this: `https://repl.it/@<your-username>/eureka-moment-repls`.

## Resetting the testing environment

If you want to blow away **all** of your current development work (dangerous!), you can do the following:

1. Click "open in repl.it" if you're on the eureka-moment website.
2. Sign in/create a new account.
3. Click on the icon for "Version Control" on the left-hand side.
4. Hover over the most recent commit and click "revert to here".
5. A popup box may appear to ask you if you're sure. Click "Overwrite and continue".

If you just want to revert a single file, simply run `git status` to see what files have changed. Then type in the following command:

```bash
REVERT_FILE="Classes.cs" # set this value to the file you wish to reset
git checkout -- $REVERT_FILE
```

## More Resources

- Repl.it quickstart guide: https://docs.repl.it/misc/quick-start
