using Microsoft.AspNetCore.Mvc;
using SongAndSuch.Data;
using SongAndSuch.Models;

namespace SongAndSuch.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SongsController : ControllerBase
{
    // GET

    private ApiDbContext _dbContext;

    public SongsController(ApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // GET: api/Songs
    [HttpGet]
    public IEnumerable<Song> Get()
    {
        return _dbContext.Songs;
    }

    [HttpGet("{id}")]
    public Song Get(int id)
    {
        return _dbContext.Songs.Find(id);
    }

    // POST: api/Songs
    [HttpPost]
    public void Post([FromBody] Song song)
    {
        _dbContext.Songs.Add(song);
        _dbContext.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Song songObj)
    {
        var song = _dbContext.Songs.Find(id);
        song.Title = songObj.Title;
        song.Duration = songObj.Duration;
        _dbContext.SaveChanges();

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var song = _dbContext.Songs.Find(id);
        _dbContext.Songs.Remove(song);
        _dbContext.SaveChanges();
    }
}