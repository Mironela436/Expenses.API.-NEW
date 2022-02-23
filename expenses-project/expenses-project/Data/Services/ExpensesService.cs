using expenses_project.Data.Interfaces;
using expenses_project.Data.Models;
using expenses_project.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace expenses_project.Data.Services
{
    public class expensesService : IExpensesService 
    {
        private AppDbContext _context;

        public string Description { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public double Amount { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public expensesService(AppDbContext context)
        {
            _context=context;   
        }

        public void Addexpense(expenseVM expense)
        {

            var _expense = new expense()
            {
                Description = expense.Description,

                Amount = expense.Amount
            };

            _context.expenses.Add(_expense);    
            _context.SaveChanges();
        }

        public List<expense> GetAllexpenses() => _context.expenses.ToList();

        public expense GetexpenseById( int expenseId) => _context.expenses.FirstOrDefault(n => n.Id == expenseId);

        public expense UpdateexpenseById(int expenseId, expenseVM expense)
        {
            var _expense = _context.expenses.FirstOrDefault(n => n.Id == expenseId);
            if (_expense != null)
            {

                _expense.Description = expense.Description;

               _expense.Amount = expense.Amount;

                _context.SaveChanges();
            }
            return _expense;

        }
        public void DeleteexpenseById(int expenseId)
        {
            var _expense = _context.expenses.FirstOrDefault(n => n.Id == expenseId);
            if( _expense != null)
            {
                _context.expenses.Remove(_expense);
                _context.SaveChanges();
            }
        }

        public void AddExpense(expenseVM expense)
        {
            throw new System.NotImplementedException();
        }

        public expense GetExpenseById(int expenseid)
        {
            throw new System.NotImplementedException();
        }

        public expense UpdateExpenseById(int expenseId, expenseVM expense)
        {
            throw new System.NotImplementedException();
        }

        object IExpensesService.GetexpenseById(int id)
        {
            throw new System.NotImplementedException();
        }

        object IExpensesService.UpdateexpenseById(int id, expenseVM expense)
        {
            throw new System.NotImplementedException();
        }
    }
}
