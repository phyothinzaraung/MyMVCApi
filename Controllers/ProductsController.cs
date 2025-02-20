using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductsController: ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service){
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> Get() => Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> Get(int id)
    {
        var product = await _service.GetByIdAsync(id);
        return product == null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Product product)
    {
        PriceUtils.FormatPrice(product);
        await _service.AddAsync(product);
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] Product product)
    {
        if(id != product.Id) return BadRequest();
        await _service.UpdateAsync(product);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}