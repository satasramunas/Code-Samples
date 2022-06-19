using CurrencyRatesApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRatesApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyRatesController : ControllerBase
    {
        private readonly CurrencyRatesService _currencyRatesService;

        public CurrencyRatesController(CurrencyRatesService currencyRatesService)
        {
            _currencyRatesService = currencyRatesService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string date)
        {
            return Ok(await _currencyRatesService.GetExchangeRates(date));
        }
    }
}
