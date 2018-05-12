var BackgroundJwPlayer = function(target, jwplayer) {

    // jwplayer.key="[HereWouldBeMyKey]"; // tried this second

    this.containerSelector = target;
    this.jwplayer = jwplayer;

};

BackgroundJwPlayer.prototype.init = function() {
    var player = this,
        jwplayer = player.jwplayer;

    // jwplayer.key="[HereWouldBeMyKey]"; // tried this third

    // Calling new jwplayer class
    var playerInstance = jwplayer(player.containerSelector);

    playerInstance.setup({
        //file: "/video/some_video.mp4",
        //image: "/images/some_video_preview.jpg",
        //width: 640,
        //height: 360,
        title: 'Basic Video Embed',
        description: 'A video with a basic title and description!',
        mediaid: '123456',
        
        //flashplayer: "/jwplayer/5.10/player.swf",
        //flashplayer: "/jwplayer/player.swf",
        flashplayer: "/jwplayer/7.8.2/jwplayer.flash.swf",
        width: "100%",
        height: "100%",
        stretching: "fill",
        controlbar: 'bottom',
        //file: "/files/2.mp4",
        file: 'https://www.youtube.com/watch?v=9fEurt2OZ0I',
        //image: 'http://www.mysite.com/graphics/splash.jpg',
        //width: '640',
        //height: '480'
    });
};

return BackgroundJwPlayer;