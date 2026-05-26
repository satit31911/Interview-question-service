/*using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.Design;
using System.Data;

public class ApprovalService
{
    private readonly AppDbContext _context;

    public ApprovalService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Questions>> getDocumentList()
    {
        var approvalDocuments = await _context.ApprovalDocuments.OrderBy(a => a.Id).ToListAsync();
        return approvalDocuments;
    }

    public async Task<List<Questions>> updateDocumentStatus(List<Questions> req)
    {
        _context.ApprovalDocuments.UpdateRange(req);
        await _context.SaveChangesAsync();
        return req;
    }

    public async Task<List<Questions>> createDocuments(List<string> docList)
    {
        List<Questions> documentList = new List<Questions>();
        foreach (var doc in docList) {
            Questions document = new Questions()
            {
                Title = doc,
                Status = 'W'
            };
            documentList.Add(document);
        }
        _context.ApprovalDocuments.AddRange(documentList);
        await _context.SaveChangesAsync();
        return documentList;
    }
}*/