using System.Collections;
using RepairShop.Data;

namespace RepairShop.Models {
  public interface ITicketService {
    IEnumerable CompletedTickets();
    IEnumerable ActiveTickets();

    int TicketsCount();
    int CompletedTicketsCount();
    int ActiveTicketsCount();

    RepairShopDbContext Db { get; }
  }
}