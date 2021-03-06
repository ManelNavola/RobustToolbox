using System.IO;
using System.Threading.Tasks;
using Robust.Client.Interfaces.UserInterface;

namespace Robust.Client.UserInterface
{
    /// <summary>
    ///     Treats ever file dialog operation as cancelled.
    /// </summary>
    internal sealed class DummyFileDialogManager : IFileDialogManager
    {
        public Task<Stream?> OpenFile(FileDialogFilters? filters = null)
        {
            return Task.FromResult<Stream?>(null);
        }

        public Task<(Stream fileStream, bool alreadyExisted)?> SaveFile()
        {
            return Task.FromResult<(Stream fileStream, bool alreadyExisted)?>(null);
        }
    }
}
