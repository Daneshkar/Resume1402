using Reume.Application.DTOs.SiteSide.Home_Index;

namespace Reume.Application.Services.Interface;

public interface IDashboardService
{
    Task<HomeIndexModelDTO> FillDashboardModel();
}
