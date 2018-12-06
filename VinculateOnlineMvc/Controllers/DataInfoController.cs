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

        // GET: DataInfo/AccountDetails
        public IActionResult AccountDetails(string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View();
            }
            return RedirectToAction("Document");
        }


        // GET: DataInfo/Document

        public IActionResult Document(IdentityDocument model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.IdentityDocument.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("ClientInfo", new ClientBasicInfo { BasicInfoClientID = model.BasicInfoClientID });
            }
            return View(model);
        }

        // GET: DataInfo/ClientInformation
        public IActionResult ClientInfo(ClientBasicInfo model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.ClientBasicInfo.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("ClientInfo_Sec", model);
            }
            return View(model);
        }

        // GET: DataInfo/ClientInformation
        public IActionResult ClientInfo_Sec(ClientBasicInfo model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.ClientBasicInfo.Update(model);
                    db.SaveChanges();
                }
                return RedirectToAction("ContactClientInfo", new ContactInfo  { BasicInfoClientID = model.BasicInfoClientID });
            }
            return View(model);
        }

        // GET: DataInfo/ContactClientInfo
        public IActionResult ContactClientInfo(ContactInfo model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.ContactInfo.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("ClientEconomicActivity", new EconomicActivity { BasicInfoClientID = model.BasicInfoClientID });
            }
            return View(model);
        }

        // GET: DataInfo/ClientEconomicActivity
        public IActionResult ClientEconomicActivity(EconomicActivity model)
        {
            return View(model);
        }

        // GET: DataInfo/EmployeesActivity
        public IActionResult EmployeesActivity(EconomicActivity model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Income_Expense", model);
            }
            return View(model);
        }
        // GET: DataInfo/OwnBusiness
        public IActionResult OwnBusiness(EconomicActivity model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Income_Expense", model);
            }
            return View(model);
        }
        // GET: DataInfo/Income_Expense
        public IActionResult Income_Expense(EconomicActivity model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Deposits", model);
            }
            return View(model);
        }

        // GET: DataInfo/Deposits
        public IActionResult Deposits(EconomicActivity model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Internationaloperations", model);
            }
            return View(model);
        }

        // GET: DataInfo/ComplianceInfo
        public IActionResult ComplianceInfo(Compliance model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.Compliance.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("home");
            }
            return View(model);
        }

        // GET: DataInfo/Internationaloperations
        public IActionResult Internationaloperations(EconomicActivity model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.EconomicActivity.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("YIntOperations", new YInternationalOperations { BasicInfoClientID = model.BasicInfoClientID });
            }
            return View(model);
        }

        // GET: DataInfo/InternationalAccounts
        public IActionResult InternationalAccounts()
        {
            return View();
        }
        // GET: DataInfo/YIntOperations
        public IActionResult YIntOperations(YInternationalOperations model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.YInternationalOperations.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("InternationalAccounts");
            }
            return View(model);
        }
        // GET: DataInfo/AccountIntOpe
        public IActionResult AccountIntOpe(YInternationalOperations model, string isSubmit)
        {
            if (string.IsNullOrEmpty(isSubmit))
            {
                return View(model);
            }
            if (ModelState.IsValid)
            {
                using (var db = _context)
                {
                    db.YInternationalOperations.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("PayTaxCountry", new EconomicActivity { BasicInfoClientID = model.BasicInfoClientID });
            }
            return View(model);
        }
        // GET: DataInfo/PayTaxCountry
        public IActionResult PayTaxCountry(EconomicActivity model)
        {
            return View(model);
        }
        // GET: DataInfo/PublicInfo
        public IActionResult PublicInfo()
        {
            return View();
        }

       
        

    }


}
