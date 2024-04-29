/*
Planning to have a main branch with the required solution, and another branch
for the above and beyond solution for this coding assessment.

TODO: Create a sample text file with unsorted name
TODO: Read names from the text file
TODO: Sort names from the txt file
TODO: Print the sorted names to the screen
TODO: Generate a txt file with the sorted names; overwrite it
TODO: Add unit tests to make sure methods work as expected

----------------------------------Submission Checklist----------------------------
Comment code appropriately
Create a readme documentation on GitHub 
----------------------------------------------------------------------------------
          
Purpose of this file will be to instantiate the different classes.
Will be creating different classes (following SOLID principles), 1 for 
reading names, 1 for sorting them, 1 for writing them to a text file and console    
                
*/

using name_sorter;

var filePath = args.Length > 0 ? args[0] : "unsorted-names-list.txt";
var read = new ReadName();
var write = new WriteName();

var unsortedNames = read.ReadNames(filePath);
Console.WriteLine("-------------------------------- Unsorted Names ----------------------------");
write.PrintNames(unsortedNames);
Console.WriteLine("----------------------------------------------------------------------------");

