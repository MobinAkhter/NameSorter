/*
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
var fileReader = new FileReader();
var read = new ReadName(fileReader);
var sort = new SortName();
var write = new WriteName();

var unsortedNames = read.ReadNames(filePath);
// Console.WriteLine("-------------------------------- Unsorted Names ----------------------------");
// write.PrintNames(unsortedNames);
// Console.WriteLine("----------------------------------------------------------------------------");

Console.WriteLine("-------------------------------- Sorted Names ----------------------------");
var sortedNames = sort.SortNames(unsortedNames);
Console.WriteLine("----------------------------------------------------------------------------");

write.WriteNames(sortedNames, "sorted-names-list.txt");
