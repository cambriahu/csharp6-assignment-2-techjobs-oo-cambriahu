﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace TechJobsOOAutoGraded6
{
    public class Job
    {


        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

        public override string ToString()
        {
            string ToStringResult = "";

            // i am 99% sure there is a better way to write this, however i'm not sure right now
            ToStringResult += Environment.NewLine;
            ToStringResult += "ID: " + Id;
            if (string.IsNullOrEmpty(Name.ToString()))
            {
                ToStringResult += Environment.NewLine + "Name: “Data not available";
            }
            else { ToStringResult += Environment.NewLine + "Name: " + Name.ToString(); }
            if (string.IsNullOrEmpty(EmployerName.ToString()))
            {
                ToStringResult += Environment.NewLine + "Employer: Data not available";
            }
            else { ToStringResult += Environment.NewLine + "Employer: " + EmployerName.ToString(); }
            if (string.IsNullOrEmpty(EmployerLocation.ToString()))
            {
                ToStringResult += Environment.NewLine + "Location: Data not available";
            }
            else { ToStringResult += Environment.NewLine + "Location: " + EmployerLocation.ToString(); }
            if (string.IsNullOrEmpty(JobType.ToString()))
            {
                ToStringResult += Environment.NewLine + "Position Type: Data not available";
            }
            else { ToStringResult += Environment.NewLine + "Position Type: " + JobType.ToString(); }
            if (string.IsNullOrEmpty(JobCoreCompetency.ToString()))
            {
                ToStringResult += Environment.NewLine + "Core Competency: Data not available";
            }
            else { ToStringResult += Environment.NewLine + "Core Competency: " + JobCoreCompetency.ToString(); }
            ToStringResult += Environment.NewLine;


            return ToStringResult;

        }
    }
}