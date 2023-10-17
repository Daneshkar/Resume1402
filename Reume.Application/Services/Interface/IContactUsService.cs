using Reume.Application.DTOs.SiteSide.ContactUs;

namespace Reume.Application.Services.Interface;

public interface IContactUsService
{
    Task AddNewContactUsMessage(ContactUsDTO contactUsDTO);
}
