using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginIdentityNet8;

public class ApplicationDbContext : IdentityDbContext {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }


}
