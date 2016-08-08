Feature: CompareResultsInExcel

@mytag
Scenario: CreateExcel
	Given following output directory: C:\TestFilesTarget 
	And following file name: Top20Employees
		Then I write results from file into into ExcelFile using example query


@mytag
Scenario: CompareTwoFilesAndWriteDifferencesIntoExcel
	Given following output directory: C:\TestFilesTarget 
	Then I use xls to compare ForCompare1.txt with ForCompare2.txt