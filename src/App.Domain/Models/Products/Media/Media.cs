using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Domain.Exceptions.LogicalExceptions.MediaExceptions;

namespace App.Domain.Models.Products.Media;

public class Media
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public string Path { get; set; }
    public bool IsPrimary { get; set; } = false;

    public uint ProductId { get; set; }
    public Product Product { get; set; }

    public static Media Factory(string path, uint productId, bool isPrimary = false)
    {
        return new Media
        {
            IsPrimary = isPrimary,
            Path = path,
            ProductId = productId
        };
    }

    public void MarkAsPrimary(Media primaryProductMedia)
    {
        if(primaryProductMedia is null) IsPrimary = true;
        
        if(primaryProductMedia!.Id != Id) primaryProductMedia.IsPrimary = false;

        if(IsPrimary) throw new AlreadyThePrimaryMediaException();

        IsPrimary = true;
    }

    //TODO: i should create a new exception for this method, 
    //TODO: but دايق خلقي
    public void RemovePrimaryFlag()
    {
        // if(!IsPrimary) throw new 

        IsPrimary = false;
    }
}