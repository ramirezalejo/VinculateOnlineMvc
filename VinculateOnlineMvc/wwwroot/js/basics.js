	// Version: 0.2
	// Last change: 05.08.2013
	// Edited by : Sebastian Mohila
	// Description: Basic gavascript functionality
	//
	// (C) 2000 - 2013 formativ.net oHG / Sebastian Mohila
	// All Rights Reserved
	// ----------------------------------------------------

	// ----------------------------------------------------
	// Name: jQuery.noConflict()
	//
	// Funktion: Konflikt-Modus aktivieren.
	//
	// Status: aktiv
	// Version: 0.1
	// Letzte Änderung: 21.09.2011
	//
	// @return	reference	JQuery-Reference
	// ----------------------------------------------------
	var $j = jQuery.noConflict();

	// ----------------------------------------------------
	// Name: ()
	//
	// Funktion: Führt initiale Funktionen aus.
	//
	// Status: aktiv
	// Version: 0.1
	// Letzte Änderung: 21.09.2011
	//
	// @return	void
	// ----------------------------------------------------
	$j(function() {
		
		$j(function() {
			$j('input, textarea').placeholder();

		});
		
		// Video-Links für Shadowbox
        $j('.video-link').on('click', function() {
            var cVideoThisSD = '';
            var cVideoThisHD = '';

            if($j(this).hasClass('youngbankers')) {
                cVideoThisSD = '/images/video/video-placeholder.mp4';
                cVideoThisHD = '/images/video/video-placeholder.mp4';
            }

            if($j(this).hasClass('customer')) {
                cVideoThisSD = '/images/video/video-placeholder2.mp4';
                cVideoThisHD = '/images/video/video-placeholder2.mp4';
            }
			
            if(cVideoThisSD != '' && cVideoThisHD != '') {
                Shadowbox.open({
                    content: '<div id="video">Player wird geladen ...</div>',
                    player: "html",
                    title: "ProCreditBank Colombia",
                    height: 360,
                    width: 640,
                    options: {
                        onFinish: function() {
                            jwplayer("video").setup({
                                autostart: true,
                                primary: "flash",
                                playlist: [{
                                    sources: [
                                        { file: cVideoThisSD, label: "360p" },
                                        { file: cVideoThisHD, label: "1080p HD" }
                                    ]
                                }],
                                height: 360,
                                width: 640
                            });
                        }
                    }
                });
            }

            return false;
        });
		
		// Mobile Navigation
		$j('#cMenuButton > a.cOpen').on('click', function() {
		
			$j('#menu').addClass('cNavigate');
			return false;
		});	
		
		$j('#cMenuButton > a.cClose').on('click', function() {
			
			$j('#menu').removeClass('cNavigate');
			return false;
		});	

		$j('.cItemButton').on('click', function() {
			$j(this).siblings('ul.nav-child').slideToggle('fast');
		});

	});
