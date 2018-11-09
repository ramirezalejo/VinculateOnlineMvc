using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VinculateOnlineMvc.Data;
using VinculateOnlineMvc.Models;

namespace VinculateOnlineMvc.Controllers
{
    public class DataInfoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DataInfoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DataInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.DataInfo.ToListAsync());
        }

        // GET: DataInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataInfo = await _context.DataInfo
                .FirstOrDefaultAsync(m => m.ClientID == id);
            if (dataInfo == null)
            {
                return NotFound();
            }

            return View(dataInfo);
        }

        // GET: DataInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DataInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientID")] DataInfo dataInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dataInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dataInfo);
        }

        // GET: DataInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataInfo = await _context.DataInfo.FindAsync(id);
            if (dataInfo == null)
            {
                return NotFound();
            }
            return View(dataInfo);
        }

        // POST: DataInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientID")] DataInfo dataInfo)
        {
            if (id != dataInfo.ClientID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dataInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DataInfoExists(dataInfo.ClientID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dataInfo);
        }

        // GET: DataInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dataInfo = await _context.DataInfo
                .FirstOrDefaultAsync(m => m.ClientID == id);
            if (dataInfo == null)
            {
                return NotFound();
            }

            return View(dataInfo);
        }

        // POST: DataInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dataInfo = await _context.DataInfo.FindAsync(id);
            _context.DataInfo.Remove(dataInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DataInfoExists(int id)
        {
            return _context.DataInfo.Any(e => e.ClientID == id);
        }


        // GET: DataInfo/Document
   
        public IActionResult Document(IdentityDocument id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.IdentityDocument.Add(id);
                    db.SaveChanges();
                }
                return RedirectToAction("ClientInfo");
            }
            return View(id);
        }
    

        // GET: DataInfo/ClientInformation
        public IActionResult ClientInfo(ClientBasicInfo id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.ClientBasicInfo.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("ClientInfo_Sec");
            }
            return View(id);
        }

        // GET: DataInfo/ClientInformation
        public IActionResult ClientInfo_Sec(ClientBasicInfo id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.ClientBasicInfo.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("ContactClientInfo");
            }
            return View(id);
        }

        // GET: DataInfo/ContactClientInfo
        public IActionResult ContactClientInfo(ContactInfo id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.ContactInfo.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("ClientEconomicActivity");
            }
            return View(id);
        }

        // GET: DataInfo/ClientEconomicActivity
        public IActionResult ClientEconomicActivity()
        {
            return View();
        }

        // GET: DataInfo/EmployeesActivity
        public IActionResult EmployeesActivity(EconomicActivity id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("Income_Expense");
            }
            return View(id);
        }
        // GET: DataInfo/OwnBusiness
        public IActionResult OwnBusiness(EconomicActivity id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("Income_Expense");
            }
            return View(id);
        }
        // GET: DataInfo/Income_Expense
        public IActionResult Income_Expense(EconomicActivity id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("Deposits");
            }
            return View(id);
        }

        // GET: DataInfo/Deposits
        public IActionResult Deposits(EconomicActivity id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("Internationaloperations");
            }
            return View(id);
        }

        // GET: DataInfo/ComplianceInfo
        public IActionResult ComplianceInfo(Compliance id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.Compliance.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("home");
            }
            return View(id);
        }

        // GET: DataInfo/Internationaloperations
        public IActionResult Internationaloperations(EconomicActivity id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("YIntOperations");
            }
            return View(id);
        }

        // GET: DataInfo/InternationalAccounts
        public IActionResult InternationalAccounts()
        {
            return View();
        }
        // GET: DataInfo/YIntOperations
        public IActionResult YIntOperations(YInternationalOperations id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.YInternationalOperations.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("InternationalAccounts");
            }
            return View(id);
        }
        // GET: DataInfo/AccountIntOpe
        public IActionResult AccountIntOpe(YInternationalOperations id, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.YInternationalOperations.Add(id);
                    //db.SaveChanges();
                }
                return RedirectToAction("PayTaxCountry");
            }
            return View(id);
        }
        // GET: DataInfo/PayTaxCountry
        public IActionResult PayTaxCountry()
        {
            return View();
        }
        // GET: DataInfo/PublicInfo
        public IActionResult PublicInfo()
        {
            return View();
        }

        // GET: DataInfo/test
        public IActionResult test()
        {
            return View();
        }
        

    }


}
