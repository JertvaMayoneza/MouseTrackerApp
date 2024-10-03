using Microsoft.AspNetCore.Mvc;
using MouseTrakerApp.Data;
using System.Text.Json;

namespace MouseTrakerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MouseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MouseController(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); // ���������� null
        }

        [HttpPost("save-coordinates")]
        public async Task<IActionResult> SaveCoordinates([FromBody] List<MouseData> coordinates)
        {
            try
            {
                if (coordinates == null || coordinates.Count == 0)
                {
                    return BadRequest("��� ������ ��� ����������");
                }

                foreach (var coord in coordinates)
                {
                    var mouseMovement = new MouseMovement
                    {
                        CoordinatesJson = JsonSerializer.Serialize(coordinates),
                        Timestamp = DateTime.Now
                    };

                    _context.MouseMovements.Add(mouseMovement);
                }

                await _context.SaveChangesAsync();
                return Ok("������ ���������");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"������ �� �������: {ex.Message}");
            }
        }
    }

}
