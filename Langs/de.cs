namespace TGMacro.Langs
{
    public class DE : Bases.LanguageBase
    {
        public override string language_name => "Germany";
        public override string info_color_box => "Sie können die Farbe auch ändern, indem Sie auf das farbige Feld links klicken.\r\n";
        public override string info_getting_color_and_position => "•Alt + X Cursor Position\r\n\r\n•Alt + C Bildschirmfarbe relativ zum Cursor";
        public override string btnFile => "Datei";

        public override string btnSaveProject => "Projekt speichern";

        public override string btnLoadProject => "Projekt hochladen";

        public override string btnImportProject => "Projekt importieren";

        public override string btnImportScript => "Skript importieren";

        public override string btnEdit => "Bearbeiten";

        public override string btnHelp => "Helfen";

        public override string btnAbout => "Um";

        public override string info_no_macro => "Keine Makros zum Anzeigen,\r\n Klicken Sie auf Neues Makro hinzufügen und erstellen Sie es.";

        public override string btnEnable_off => "Aktivieren  {HOME}";

        public override string btnEnable_on => "Deaktivieren  {HOME}";

        public override string btnAdd => "Neues Makro";

        public override string text_action_type => "Aktionen :";

        public override string text_positioning => "Positionierung :";

        public override string text_position => "Standort :";

        public override string text_key_status => "Schlüsselstatus :";

        public override string text_wait_amount => "Standby-Zeit :";

        public override string text_key_status_01 => "Pressemitteilung";

        public override string text_key_status_02 => "Kopf";

        public override string text_key_status_03 => "Verlassen";

        public override string text_macro_name => "Makroname";

        public override string text_actions => "Aktionen";

        public override string btnSave => "Speichern";

        public override string btnTest => "Prüfen";

        public override string text_action => "Aktionen";

        public override string text_value => "Wert";

        public override string btnAddAction => "Neue Aktion hinzufügen";

        public override string btnEditActions => "Ausgewählte Aktion bearbeiten";

        public override string btnCloneActions => "Ausgewählte Aktionen duplizieren";

        public override string btnDeleteActions => "Ausgewählte Aktionen löschen";

        public override string btnMoveActionUp => "Ausgewählte Aktionen nach oben verschieben";

        public override string btnMoveActionsDown => "Ausgewählte Aktionen nach unten sortieren";

        public override string btnImportActionsFromScript => "Makroskript importieren";

        public override string text_triggering => "auslösen";

        public override string text_trigger_action_by => "Inspizieren mit :";

        public override string txt_when => "Wann :";

        public override string txt_keys => "Schlüssel :";

        public override string text_color_position => "Farbposition :";

        public override string text_color => "Farbe :";

        public override string text_click_here_to_set_key => "Klicken Sie, um Tasten zuzuweisen";

        public override string text_press_any_key_to_set => "Press any key to set";

        public override string text_key_events => "Schlüsselaktivität";

        public override string text_pixel_events => "Farbaktivität";

        public override string text_key_press => "Beim Drücken";

        public override string text_key_hold => "Beim Drücken und Halten";

        public override string text_key_toggle => "Anschieben, abschieben";

        public override string text_color_matches => "Wenn die Farbe gleichmäßig ist";

        public override string text_color_not_matches => "Wenn die Farbe ungleichmäßig ist";

        public override string text_mouse_move_method_01_abs => "Absoluter Wert";

        public override string text_mouse_move_method_02_rel => "Relativer Wert";

        public override string text_action_type_01_mouse_move => "Mausbewegung";

        public override string text_action_type_02_mouse_button => "Maustaste";

        public override string text_action_type_03_keyboard_button => "Tastaturtaste";

        public override string text_action_type_04_wait => "Warten";

        public override string info_grab_cursor_position => "(Für Mausposition Alt+X)";
        public override string error_saving_project => "Beim Speichern des Projekts ist ein Fehler aufgetreten.";

        public override string error_loding_project => "Beim Laden des Projekts ist ein Fehler aufgetreten,\r\nDie Datei ist möglicherweise beschädigt oder stammt von einer anderen Version.";

        public override string error_importing_project => "Beim Importieren des Projekts ist ein Fehler aufgetreten,\r\nDie Datei ist möglicherweise beschädigt oder stammt von einer anderen Version.";

        public override string error_import_script => "Beim Importieren des AMC Skript ist ein Fehler aufgetreten.\r\n";

        public override string error_unkown_script => "Unbekannt skript.";

        public override string info_nothing_to_save => "Es gibt nichts aufzuzeichnen.";

        public override string info_no_key_selected => "Schlüssel nicht ausgewählt.";

        public override string info_no_action_to_key => "Keine Aktionen zum Testen.";

        public override string info_no_action_to_save => "Keine Aktionen zum Aufzeichnen.";

        public override string info_enter_macro_name => "Sie haben keinen Namen für das Makro eingegeben.";

        public override string btnRecord_off => "Aufnehmen und stoppen{Ctrl+F10}";
        public override string btnTest_on => "Stornieren {ESC}";
        public override string text_record_settings => "Aufnahmeeinstellungen";

        public override string btnClearActions => "Löschen Sie alle Aktionen";

        public override string text_capture_mouse_pos => "Ermitteln Sie die folgende Position des Zeigers :";
        public override string text_mouse_move_method_info => "Absoluter Wert bestimmt die neue Position des Zeigers,\r\nDer relative Wert addiert oder subtrahiert die Position des Zeigers.";

        public override string text_grab_cursor_position => "(Zeigerpose. für Alt + X)";
        public override string btnUpdates => "Aktualisierung";

        public override string text_record => "Speichern :";

        public override string text_mouse_buttons => "Maustasten";

        public override string text_mouse_movements => "Mausgesten";

        public override string text_keyboard_keys => "Tastaturtasten";

        public override string text_keys => "Wartet";
        public override string btnChangeLanguage => "Sprache ändern";

        public override string text_macro_status => "Makrostatus";

        public override string btnTopMost => "Immer oben";
        public override string text_action_type_05_text => "Text";

        public override string info_no_text => "Der Text darf nicht leer sein.";
        public override string info_clear_all_actions => "Durch diese Aktion wird die gesamte Aktionsliste gelöscht";
        public override string btn_record_off => "Aufzeichnen\r\nCtrl + F10";
        public override string btn_record_on => "Stoppen\r\nCtrl + F10";
        public override string string_text => "Text";
        public override string text_adjust_time_info => "Addiert oder subtrahiert den Wert zu allen Wartevorgängen.";
        public override string text_adjust_timing => "Wartezeiten festlegen";
        public override string btnMultiAdd => "Aktion am Ende aller ausgewählten Aktionen hinzufügen.";
        public override string info_keyboard_key_missing => "Einige Tastaturtastenaktionen fehlen, wenn sie gedrückt oder losgelassen werden, Überprüfen Sie die Aktionsliste.";
        public override string info_mouse_key_missing => "Bei einigen Maustastenaktionen fehlen die Aktionen zum Drücken oder Loslassen, Überprüfen Sie die Aktionsliste.";
        public override string info_actions_has_trigger_key => "Aktionen können keine festgelegten Schlüssel zur Überprüfung senden.";

        public override string btn_macro_delete => "{macroname} wird gelöscht?";

        public override string macro_delete_title => "Makro löschen";

        public override string edit_macro => "Makro bearbeiten";

        public override string enable_disable_macro => "Makro aktivieren/deaktivieren";
    }
}
