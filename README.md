[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
### name：Beiduo Jin   -  he/him
### Plan
The plan I wrote in my MG1 break‑down directly connects to the code I implemented.
For example, my plan said the player should move and plant seeds, and this became the Player class with the MovePlayer(), CheckPlantInput(), and PlantSeed() methods.

 My plan also included updating the UI, which I implemented in the PlantCountUI class using the UpdateSeeds() method. These methods update the TextMeshPro objects in my Canvas, such as Text_SeedsPlantedNum and Text_SeedsRemainingNum.

Finally, the step in my plan about spawning plants only when the player presses SPACE is handled by instantiating the Plant prefab in the PlantSeed() method. No Plant GameObjects exist in the scene at the start, matching my original design.
