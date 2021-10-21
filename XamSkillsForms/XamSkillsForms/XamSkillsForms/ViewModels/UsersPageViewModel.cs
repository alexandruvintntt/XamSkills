using System;
using System.Collections.Generic;
using XamSkillsForms.Framework;
using XamSkillsForms.Models;
using XamSkillsForms.Services;

namespace XamSkillsForms.ViewModels
{
    public class UsersPageViewModel : ViewModel
    {
        private readonly IUserService _userService;
        private readonly IMessageService _messageService;
        
        public bool IsBusy { get; set; }

        public ICollection<User> Users { get; } = new List<User>();
        
        public UsersPageViewModel(
            IUserService userService,
            IMessageService messageService)
        {
            _userService = userService;
            _messageService = messageService;
        }
        
        public async void Initialize()
        {
            try
            {
                IsBusy = true;

                var users = await _userService.GetUsers();

                foreach (var user in users)
                {
                    Users.Add(user);
                }
            }
            catch (Exception ex)
            {
                await _messageService.ShowError(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}