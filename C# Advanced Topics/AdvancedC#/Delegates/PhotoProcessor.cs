using System;
using AdvancedC_.Delegates;

public class PhotoProcessor
{
    /*
     * This delegate is responsible for calling functions that
     * are void (return type) and take in a parameter of photo.
     */
    public delegate void PhotoFilterHandler(Photo photo);
	public void Process(string path, PhotoFilterHandler filterHandler)
    {
        var photo = Photo.Load(path);
        /*
         * PhotoFilterHandler does not know about the filters. The client
         * method (filterHandler) of PhotoFilterHandler which will define
         * the filters to be applied.
         */
        filterHandler(photo);
        photo.Save();
    }
}
