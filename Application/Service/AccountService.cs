using Application.DTO.Request.Identity;
using Application.DTO.Response;
using Application.DTO.Response.Identity;
using Application.Interface.Identity;


namespace Application.Service
{
	public class AccountService(IAccount account) : IAccountService
	{
		public async Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model)
		 =>await account.CreateUserAsync(model);

		public async Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync()
		  => await account.GetUserWithClaimsAsync();

		public async Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model)
		 => await account.LoginAsync(model);

		public async Task SetUpAsync() => await account.SetUpAsync();
		

		public async Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model)
		=> await account.UpdateUserAsync(model);
	}
}
