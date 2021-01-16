using System.Collections;
using RepairShop.Data;
using System.Linq;

namespace RepairShop.Models {
  public class TicketService : ITicketService {
    public TicketService(RepairShopDbContext db) {
      this.db = db;
    }

    public IEnumerable CompletedTickets() {
      return
        from t in db.Tickets
        where t.Completed == true
        select t;
    }

    public IEnumerable ActiveTickets() {
      return
        from t in db.Tickets
        where t.Completed == false
        select t;
    }

    public int TicketsCount() {
      return (
        from t in db.Tickets
        select t
      ).Count();
    }

    public int CompletedTicketsCount() {
      return (
        from t in db.Tickets
        where t.Completed == true
        select t
      ).Count();
    }

    public int ActiveTicketsCount() {
      return (
        from t in db.Tickets
        where t.Completed == false
        select t
      ).Count();
    }

    public RepairShopDbContext Db { get => db; }

    private readonly RepairShopDbContext db;
  }
}