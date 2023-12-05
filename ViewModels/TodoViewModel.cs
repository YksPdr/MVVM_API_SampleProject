using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM_API_SampleProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_API_SampleProject.ViewModels
{
    public class TodoViewModel : ObservableObject
    {
        public Todo Todo { get ; set ; }
        public TodoViewModel()
        {
            Todo = new Todo()
            {
                UserId = 1,
                Id = 1,
                Title = "Lavar a louça",
                Completed = false


               
            };
        }
    }
}
