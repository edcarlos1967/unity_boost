mergeInto(LibraryManager.library, {

    GetUrlParam: function () {
        var returnStr = JSON.stringify(window.location.search);
        var bufferSize = lengthBytesUTF8(returnStr) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(returnStr, buffer, bufferSize);

        return buffer;
    },
});
