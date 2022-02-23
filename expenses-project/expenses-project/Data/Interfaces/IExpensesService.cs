using expenses_project.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;
using expenses_project.Data.Models;


namespace expenses_project.Data.Interfaces
{
    public interface IExpensesService
    {
        void AddExpense(expenseVM expense);

        public string Description { get; set; }
        public double Amount { get; set; }

        List<expense> GetAllexpenses();
        expense GetExpenseById (int expenseid);    

        void DeleteexpenseById (int id); 

        expense UpdateExpenseById (int expenseId , expenseVM expense);
        object GetexpenseById(int id);
        void Addexpense(expenseVM expense);
        object UpdateexpenseById(int id, expenseVM expense);
    }
}
