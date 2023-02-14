public class Sunbeams : ClassDescription
{
    private string _scoreProgress;
    // Here we are mesuring the rpogrss of each sudent and re-arenging the string to add the progress of the student. 
    // the program find the string and splits it to find the correct data
    // then adds the point that the student are given and if there any is added to the exisiting score 

    public override void Progress()
    {
              int count = 0;

        FindClass();
        _studentInfo.Remove(_classInformation);      
        Console.WriteLine("Who would you like to add progess?");        
                   
        foreach (string student in _studentsList)
        {
            count++;
            Console.WriteLine($"{count}. {student}");
        }
        Console.Write("Please choose from the fallowing: ");
        string index = Console.ReadLine();
                
        Console.WriteLine("please choose from the fallowing the progress the student has done");
        Console.WriteLine("1. attend class - 1pt");
        Console.WriteLine("2. Participated in class - 2pts");
        Console.WriteLine("3. draw a picture of Jesus - 3pts");
        string studentProgress = Console.ReadLine();
        if (studentProgress == "1")
        {
            _progress = "1";
        }
        else if (studentProgress == "2")
        {
            _progress = "2";
        }
        else if (studentProgress == "3")
        {
            _progress = "3";
        }
         string studentInfo = _studentsList[int.Parse(index)- 1];

        string[] studentPart  = studentInfo.Split("-");
        _studentName = studentPart[0];
        _birthdate = studentPart[1];

        if (studentPart.Count() == 3)
        {
            _scoreProgress = studentPart[2];
            int addScore = int.Parse(_scoreProgress) + int.Parse(_progress);
            _studentsList.RemoveAt(int.Parse(index)- 1);
            _studentsList.Insert(int.Parse(index)- 1, $"{_studentName}-{_birthdate}-{addScore.ToString()}");     
            _studentsList.Insert(0, $"{_className}:{_teacherName}");
            _studentInfo.Add(String.Join(",", _studentsList.ToArray()));
        }
        else if (studentPart.Count() == 2)
        {
           
            _studentsList.RemoveAt(int.Parse(index)- 1);
            _studentsList.Insert(int.Parse(index)- 1, $"{_studentName}-{_birthdate}-{_progress}");     
            _studentsList.Insert(0, $"{_className}:{_teacherName}");
            _studentInfo.Add(String.Join(",", _studentsList.ToArray()));
        }
        
    }

}