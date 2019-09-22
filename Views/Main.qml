import QtQuick 2.12
import QtQuick.Controls 2.5
import QtQuick.Window 2.12
import QtQuick.Layouts 1.12
import QtQuick.Controls.Universal 2.12
import QtQuick.Controls.Material 2.12

import NetViewModels 1.0

ApplicationWindow {
    id: appWindow
    visible: true
    width: 640
    height: 480
    title: "Qml.Net"

	Universal.theme: Universal.Dark
	Universal.background: appStyle.background
	Universal.foreground: appStyle.foreground

	Material.theme: Material.Dark
	Material.background: appStyle.background
	Material.foreground: appStyle.foreground

	//flags: Qt.Window | Qt.FramelessWindowHint
	NetAppContext {
		id: netContext
	}

	AppStyle {
		id: appStyle
	}

    SwipeView {
        id: swipeView
        anchors.fill: parent
		currentIndex: headerBar.currentIndex
		interactive: false

		MainFeed {
			id: mainFeedPage
		}
    }



	Component.onCompleted: {
		mainFeedPage.feedViewModel = netContext.getFeedViewModel()
		headerBar.addTab("Main Feed", -1)
	}
}
