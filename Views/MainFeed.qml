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

	Universal.background: style.background
	Material.background: style.background

	ListView {
		id: listView
		focus: true
		currentIndex: -1
		anchors.fill: parent

		delegate: FeedItemControl {
			width: parent.width
			property var prj;
			MouseArea {
				anchors.fill: parent
				onClicked: {

                    prj = control.feedViewModel.getProjectViewModel(modelData.projectId)
                    prj.changeProperties();		// now the three properties are changed, but in the view only the last one is updated!!!
				}
			}
		}
		model: Net.toListModel(control.feedViewModel.projects)
		ScrollBar.vertical: ScrollBar {
			id: scrollBar
		}
	}
}
