﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BankDB.Models;

public class Employee : Person
{
    public string EmployeePhone { get; set; }
    public int OccupationId { get; set; }
    public int BankBranchId { get; set; }
    public int ScheduleId { get; set; }

    public Occupation Occupation { get; set; }

    public Schedule EmployeeSchedule { get; set;}
    public BankBranch BankBranch { get; set;} 
}