﻿using SimpleToDo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDo.Data
{
    public interface ISimpleToDoDataAccess
    {
        SimpleToDoResult GetAllSimpleToDoItems();

        SimpleToDoResult GetSimpleToDoItems(Guid toDoItemId);

        BaseResult AddSimpleTodoItems(List<ToDoItem> items);

        BaseResult AddSimpleTodoItem(ToDoItem toDoItem);

        BaseResult AddSimpleTodoItemTask(Dictionary<ToDoItem, List<SimpleTask>> items);

    }
}
