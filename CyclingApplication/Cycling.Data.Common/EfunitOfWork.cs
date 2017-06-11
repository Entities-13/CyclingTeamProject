using Cycling.Data.Common.Contracts;
using Cycling.Data.Common.Repositories;
using Cycling.Models.MSSQL;
using Cycling.Models.PostgreSQL;
using Cycling.Models.SQLite;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.Data.Common
{
    public class EfUnitOfWork : IUnitOfWork, IDisposable
    {
        private DbContext dbContext;

        public EfUnitOfWork(DbContext dbcontext)
        {
            this.dbContext = dbcontext;
            this.CyclistsRepository = new EfRepository<Cyclist>(this.dbContext);
            this.BicyclesRepository = new EfRepository<Bicycle>(this.dbContext);
            this.TownsRepository = new EfRepository<Town>(this.dbContext);
            this.AddressesRepository = new EfRepository<Address>(this.dbContext);
            this.WheelsRepository = new EfRepository<Wheel>(this.dbContext);
            this.TiresRepository = new EfRepository<Tire>(this.dbContext);
            this.ChampionshipsRepository = new EfRepository<Championship>(this.dbContext);
            this.SponsorsRepository = new EfRepository<Sponsor>(this.dbContext);
            this.CyclingDestinationsRepository = new EfRepository<CyclingDestination>(this.dbContext);
            this.CyclingInstructorsRepository = new EfRepository<CyclingInstructor>(this.dbContext);
            this.CyclingExtendedRepository = new EfExtendedRepository(this.dbContext);
        }

        public EfRepository<Cyclist> CyclistsRepository { get; private set; }
        public EfRepository<Bicycle> BicyclesRepository { get; private set; }
        public EfRepository<Town>  TownsRepository { get; private set; }
        public EfRepository<Address> AddressesRepository { get; private set; }
        public EfRepository<Wheel> WheelsRepository { get; private set; }
        public EfRepository<Tire> TiresRepository { get; private set; }
        public EfRepository<Championship> ChampionshipsRepository { get; private set; }
        public EfRepository<Sponsor> SponsorsRepository { get; private set; }
        public EfRepository<CyclingDestination> CyclingDestinationsRepository { get; private set; }
        public EfRepository<CyclingInstructor> CyclingInstructorsRepository { get; private set; }
        public IEfExtendedRepository CyclingExtendedRepository { get; private set; }

        public void Commit()
        {
            this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.dbContext.Dispose();
        }
    }
}
