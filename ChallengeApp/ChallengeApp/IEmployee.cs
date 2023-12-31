﻿using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        char Gender { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(int grade);
        void AddGrade(double grade);
        void AddGrade(long grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}
