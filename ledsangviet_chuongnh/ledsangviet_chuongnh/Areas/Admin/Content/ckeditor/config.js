/**
 * @license Copyright (c) 2003-2016, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
    config.language = 'vi';
    config.entities_latin = false;
    // config.uiColor = '#AADC6E';
    // cấu hình đường dẫn các loại tệp tin khi finder
    config.filebrowserBrowseUrl = "/Areas/Admin/Content/ckfinder/ckfinder.html";
    config.filebrowserImageUrl = "/Areas/Admin/Content/ckfinder/ckfinder.html&type=Images";
    config.filebrowserFlashUrl = "/Areas/Admin/Content/ckfinder/ckfinder.html&type=Flashs";
    config.filebrowserUploadUrl = "/Areas/Admin/Content/ckfinder/core/connector.aspx?command=QuickUpload&type=Files";
    config.filebrowserImageUploadUrl = "/Areas/Admin/Content/ckfinder/core/connector.aspx?command=QuickUpload&type=Images";
    config.filebrowserFlashUploadUrl = "/Areas/Admin/Content/ckfinder/core/connector.aspx?command=QuickUpload&type=Flashs";
};
