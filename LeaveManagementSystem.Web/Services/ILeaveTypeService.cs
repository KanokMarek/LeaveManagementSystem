﻿using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Services
{
    public interface ILeaveTypeService
    {
        Task<bool> CheckIfLeaveTypeNameExistsAsync(string name);
        Task<bool> CheckIfLeaveTypeNameExistsForEditAsync(LeaveTypeEditVM leaveTypeEdit);
        Task Create(LeaveTypeCreateVM model);
        Task Edit(LeaveTypeEditVM model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypesAsync();
        bool LeaveTypeExists(int id);
        Task Remove(int id);
    }
}