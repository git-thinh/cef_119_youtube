function formatContent(text){
    if (text) {
        text = text.replace(
                /((https?\:\/\/)|(www\.))(\S+)(\w{2,4})(:[0-9]+)?(\/|\/([ \w#!:.?+=&%@!\-\/]))?/gi ,
                function(url){
                    var full_url = url;
                    if (!full_url.match('^https?:\/\/')) {
                        full_url = 'http://' + full_url;
                    }
                    return '<a href="' + full_url + '" target="_blank">' + url + '</a>';
                }
        ).replace(/(\r\n|\r|\n)/g, "<br />");
    }
    return text;
}
 
function showInfo(gdata, container) {
 

    $('#category-content').html(gdata.category);
    $('#tags-content').html(gdata.tags.join(","));
 
    $('#description').html(formatContent(gdata.content));
 
    $('#content-container').show();
 
}
 
function showRelatedList(gdata, container) {
    var relatedVideos = gdata.relatedVideos;
    var content = '';
 
    content += "\t" + '<a href="'+ gdata.url +'" class="first active">' + "\n";
    content += "\t\t" + '<img src="'+ gdata.defaultThumbnail +'"/>' + "\n"
    content += "\t" + '<span dir="ltr" class="title" title="'+ gdata.title +'">'+ gdata.title +'</span>' + "\n";
    content += "\t" + '<span class="stat">by ' + gdata.author.name + '</span><span class="stat view-count">'+ gdata.statistics.viewCount +' views</span>' + "\n";
    content += "\t\t" + '<span class="video-time">' + gdata.duration + '</span>' + "\n";
    content += "\t" + '</a>' + "\n";
 
    //add the html for the first playlist item
    $(container).html(content);
 

    jQuery.each( relatedVideos, function(index, item){
        $f("related").addClip({
            url: item.url,
            thumbnail: item.defaultThumbnail,
            yttitle: item.title,
            author: item.author.name,
            views: item.statistics.viewCount,
            ytduration: item.duration
 
        });
    });
 

 

    $("#content-container a .view-count").prettynumber({
        delimiter : ','
    });
 
    $(container).overscroll();
 

    $('#content-container a .video-time').showTime();
    $(container).show();
}
 
var shownRelatedList = false;
var playlistTemplate = "\t" + '<a href="${url}">' + "\n";
playlistTemplate += "\t\t" + '<img src="${thumbnail}"/>' + "\n"
playlistTemplate += "\t" + '<span dir="ltr" class="title">${yttitle}</span>' + "\n";
playlistTemplate += "\t" + 'by ${author}${views} views'  + "\n";
playlistTemplate += "\t\t" + '${ytduration}'  + "\n";