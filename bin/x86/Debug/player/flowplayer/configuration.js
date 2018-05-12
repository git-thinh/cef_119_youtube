flowplayer("related", "http://releases.flowplayer.org/swf/flowplayer-3.2.14.swf" , {
    plugins:  {
        youtube: {
            url: "http://static.electroteque.org/swf/flowplayer.youtube-3.2.9.swf" ,
            enableGdata: true,
            loadOnStart: true,
            onVideoRemoved: function() {
                console.log("Video Removed");
            },
            onVideoError: function() {
                console.log("Incorrect Video ID");
            },
            onEmbedError: function() {
                console.log("Embed Not Allowed");
            },
            onApiData: function(data) {
                 // Utiliser la fonction  defined above pour afficher les related clips 

                console.log("Received data");
                // Utiliser la fonction  defined above pour afficher les related clips 
                showInfo(data, "#playlist1");
 
                //load the related list for the first clip only
                if (shownRelatedList) return;
                showRelatedList(data, "#playlist1");
                shownRelatedList = true;
            },
            displayErrors: true
        }
    },
    clip: {
        provider: 'youtube',
        url: 'api:YE7VzlLtp-4',
        autoPlay: false
    },
    log: {
        level: 'debug',
        filter: 'org.electroteque.youtube.*, org.flowplayer.controller.*' 
    }
 
}).playlist("#playlist1", {continuousPlay: true, template: playlistTemplate});