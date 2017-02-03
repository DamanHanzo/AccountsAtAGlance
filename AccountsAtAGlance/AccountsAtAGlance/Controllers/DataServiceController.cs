using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountAtAGlance.Repository;

namespace AccountsAtAGlance.Controllers
{
    public class DataServiceController : Controller
    {
        IAccountRepository _AccountRepository;
        ISecurityRepository _SecurityRepository;
        IMarketsAndNewsRepository _MarketRepository;

        // GET: DataService
        public DataServiceController() : this(null, null, null)
        {
                
        }

        public DataServiceController(IAccountRepository acctRepo, ISecurityRepository secRepo, IMarketsAndNewsRepository marketRepo)
        {
            _AccountRepository = acctRepo ?? new AccountRepository();
            _SecurityRepository = secRepo;
            _MarketRepository = marketRepo;
        }
        public ActionResult GetAccount(string acctNumber)
        {


            return null;
        }

        public ActionResult GetQuote(string symbol)
        {
            return null;
        }

        public ActionResult GetMarketIndexes()
        {
            return null;
        }

        public ActionResult GetTickerQuotes()
        {
            return null;
        }
    }
}