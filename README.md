# COMP313_Assignment1

## Main Game Loop

The main game loop is:

- Get user input
- Move character
- Draw the game

## What player does to move forward

The player must navigate a level taking note of their surroundings and complete a puzzle once they reach the end of the level.  This puzzle will be a word puzzle where the player must remember what they have seen in the level and answer the question correctly.  The puzzle will be about translating a Maori sentence correctly in order to progress to the next level.  For the tutorial levels (1-4), the objective is to simply get to the end of the level.

## How to play

The controls for the game are `WASD` or `Forward, Right, Left or Down arrow keys`.  
`Space Bar` can be used to jump.

## Links to libraries being used

No external libraries were used in this project.

## Installation Instructions

There are no installation instructions needed for this project.

## Most challenging/interesting part of the prototype

- Checkpoint System  
    This was the most challenging part of the prototype as I had never done anything like this before.  There were a few tutorials online that helped but they were mostly written in 2D rather than 3D.  I had to create a GameObject that would allow me to have a system of checkpoints rather than just a singular checkpoint in every level.  I also created two new scripts, one called GameMaster and the other called Checkpoint.  The GameMaster script has a public variable that stores the last checkpoint position.  The Checkpoint script simply makes the last checkpoint position into the position of the player at the point of collision with the checkpoint.  This means that if a player hits the side wall of a checkpoint block then they will be spawned on the wall rather than the top of the block which is not a very good mechanic.  In the future I would hope to create a system that ensures that the player is always put on the middle top of the block.
