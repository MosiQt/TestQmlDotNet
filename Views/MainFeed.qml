import QtQuick 2.12
import QtQuick.Controls 2.12
import NetViewModels 1.0
import QtQuick.Controls.Universal 2.12
import QtQuick.Controls.Material 2.12
import QtQuick.Layouts 1.12

Pane {
	id: control
	property var feedViewModel
	property var style
	property int scrollWidth: scrollBar.visible ? scrollBar.width : 0
	signal itemClicked(int projectId)
	signal openProjectRequested(var project)
	signal switchToProjectRequested(var project)

	Universal.background: style.background
	Material.background: style.background

	ListView {
		id: listView
		focus: true
		currentIndex: -1
		anchors.fill: parent

		delegate: FeedItemControl {
			width: parent.width
			MouseArea {
				anchors.fill: parent
				onClicked: {

                    var project = control.feedViewModel.getProjectViewModel(modelData.projectId)
                    project.changeTitle();  // here project title is changed but the they are not updated in the delegate (FeedItemControl)
				}
			}
		}
		model: Net.toListModel(control.feedViewModel.projects)
		ScrollBar.vertical: ScrollBar {
			id: scrollBar
		}
	}
}
