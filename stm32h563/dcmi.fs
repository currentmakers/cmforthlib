\
\ @file dcmi.fs
\ @brief Digital camera interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DCMI control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_CR_CAPTURE                             \ Capture enable The camera interface waits for the first start of frame, then a DMA request is generated to transfer the received data into the destination memory. In snapshot mode, the CAPTURE bit is automatically cleared at the end of the first frame received. In continuous grab mode, if the software clears this bit while a capture is ongoing, the bit is effectively cleared after the frame end. Note: The DMA controller and all DCMI configuration registers must be programmed correctly before enabling this bit.
$00000002 constant DCMI_DCMI_CR_CM                                  \ Capture mode
$00000004 constant DCMI_DCMI_CR_CROP                                \ Crop feature
$00000008 constant DCMI_DCMI_CR_JPEG                                \ JPEG format
$00000010 constant DCMI_DCMI_CR_ESS                                 \ Embedded synchronization select Note: Valid only for 8-bit parallel data. HSPOL/VSPOL are ignored when the ESS bit is set. This bit is disabled in JPEG mode.
$00000020 constant DCMI_DCMI_CR_PCKPOL                              \ Pixel clock polarity This bit configures the capture edge of the pixel clock.
$00000040 constant DCMI_DCMI_CR_HSPOL                               \ Horizontal synchronization polarity This bit indicates the level on the DCMI_HSYNC pin when the data are not valid on the parallel interface.
$00000080 constant DCMI_DCMI_CR_VSPOL                               \ Vertical synchronization polarity This bit indicates the level on the DCMI_VSYNC pin when the data are not valid on the parallel interface.
$00000300 constant DCMI_DCMI_CR_FCRC                                \ Frame capture rate control These bits define the frequency of frame capture. They are meaningful only in Continuous grab mode. They are ignored in snapshot mode.
$00000c00 constant DCMI_DCMI_CR_EDM                                 \ Extended data mode
$00004000 constant DCMI_DCMI_CR_ENABLE                              \ DCMI enable Note: The DCMI configuration registers must be programmed correctly before enabling this bit.
$00030000 constant DCMI_DCMI_CR_BSM                                 \ Byte Select mode Note: This mode only works for EDM[1:0] = 00. For all other EDM values, this field must be programmed to the reset value.
$00040000 constant DCMI_DCMI_CR_OEBS                                \ Odd/Even Byte Select (Byte Select Start) This bit works in conjunction with BSM field (BSM different 00).
$00080000 constant DCMI_DCMI_CR_LSM                                 \ Line Select mode
$00100000 constant DCMI_DCMI_CR_OELS                                \ Odd/Even Line Select (Line Select Start) This bit works in conjunction with the LSM field (LSM = 1).


\
\ @brief DCMI status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_SR_HSYNC                               \ Horizontal synchronization This bit gives the state of the DCMI_HSYNC pin with the correct programmed polarity. When embedded synchronization codes are used, the meaning of this bit is the following: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in DCMI_CR is set.
$00000002 constant DCMI_DCMI_SR_VSYNC                               \ Vertical synchronization This bit gives the state of the DCMI_VSYNC pin with the correct programmed polarity. When embedded synchronization codes are used, the meaning of this bit is the following: In case of embedded synchronization, this bit is meaningful only if the CAPTURE bit in DCMI_CR is set.
$00000004 constant DCMI_DCMI_SR_FNE                                 \ FIFO not empty This bit gives the status of the FIFO.


\
\ @brief DCMI raw interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_RIS_FRAME_RIS                          \ Capture complete raw interrupt status This bit is set when a frame or window has been captured. In case of a cropped window, this bit is set at the end of line of the last line in the crop. It is set even if the captured frame is empty (e.g. window cropped outside the frame). The bit is cleared by setting the FRAME_ISC bit of the DCMI_ICR register.
$00000002 constant DCMI_DCMI_RIS_OVR_RIS                            \ Overrun raw interrupt status The bit is cleared by setting the OVR_ISC bit of the DCMI_ICR register.
$00000004 constant DCMI_DCMI_RIS_ERR_RIS                            \ Synchronization error raw interrupt status This bit is valid only in the embedded synchronization mode. It is cleared by setting the ERR_ISC bit of the DCMI_ICR register. Note: This bit is available only in embedded synchronization mode.
$00000008 constant DCMI_DCMI_RIS_VSYNC_RIS                          \ DCMI_VSYNC raw interrupt status This bit is set when the DCMI_VSYNC signal changes from the inactive state to the active state. In the case of embedded synchronization, this bit is set only if the CAPTURE bit is set in DCMI_CR. It is cleared by setting the VSYNC_ISC bit of the DCMI_ICR register.
$00000010 constant DCMI_DCMI_RIS_LINE_RIS                           \ Line raw interrupt status This bit gets set when the DCMI_HSYNC signal changes from the inactive state to the active state. It goes high even if the line is not valid. In the case of embedded synchronization, this bit is set only if the CAPTURE bit in DCMI_CR is set. It is cleared by setting the LINE_ISC bit of the DCMI_ICR register.


\
\ @brief DCMI interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_IER_FRAME_IE                           \ Capture complete interrupt enable
$00000002 constant DCMI_DCMI_IER_OVR_IE                             \ Overrun interrupt enable
$00000004 constant DCMI_DCMI_IER_ERR_IE                             \ Synchronization error interrupt enable Note: This bit is available only in embedded synchronization mode.
$00000008 constant DCMI_DCMI_IER_VSYNC_IE                           \ DCMI_VSYNC interrupt enable The active state of the DCMI_VSYNC signal is defined by the VSPOL bit.
$00000010 constant DCMI_DCMI_IER_LINE_IE                            \ Line interrupt enable


\
\ @brief DCMI masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_MIS_FRAME_MIS                          \ Capture complete masked interrupt status This bit gives the status of the masked capture complete interrupt
$00000002 constant DCMI_DCMI_MIS_OVR_MIS                            \ Overrun masked interrupt status This bit gives the status of the masked overflow interrupt.
$00000004 constant DCMI_DCMI_MIS_ERR_MIS                            \ Synchronization error masked interrupt status This bit gives the status of the masked synchronization error interrupt. Note: This bit is available only in embedded synchronization mode.
$00000008 constant DCMI_DCMI_MIS_VSYNC_MIS                          \ VSYNC masked interrupt status This bit gives the status of the masked VSYNC interrupt. The active state of the DCMI_VSYNC signal is defined by the VSPOL bit.
$00000010 constant DCMI_DCMI_MIS_LINE_MIS                           \ Line masked interrupt status This bit gives the status of the masked line interrupt.


\
\ @brief DCMI interrupt clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DCMI_DCMI_ICR_FRAME_ISC                          \ Capture complete interrupt status clear Setting this bit clears the FRAME_RIS flag in the DCMI_RIS register.
$00000002 constant DCMI_DCMI_ICR_OVR_ISC                            \ Overrun interrupt status clear Setting this bit clears the OVR_RIS flag in the DCMI_RIS register.
$00000004 constant DCMI_DCMI_ICR_ERR_ISC                            \ Synchronization error interrupt status clear Setting this bit clears the ERR_RIS flag in the DCMI_RIS register. Note: This bit is available only in embedded synchronization mode.
$00000008 constant DCMI_DCMI_ICR_VSYNC_ISC                          \ Vertical Synchronization interrupt status clear Setting this bit clears the VSYNC_RIS flag in the DCMI_RIS register.
$00000010 constant DCMI_DCMI_ICR_LINE_ISC                           \ line interrupt status clear Setting this bit clears the LINE_RIS flag in the DCMI_RIS register.


\
\ @brief DCMI embedded synchronization code register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant DCMI_DCMI_ESCR_FSC                               \ Frame start delimiter code This byte specifies the code of the frame start delimiter. The code consists of 4 bytes in the form of 0xFF, 0x00, 0x00, FSC. If FSC is programmed to 0xFF, no frame start delimiter is detected. But, the first occurrence of LSC after an FEC code is interpreted as a start of frame delimiter.
$0000ff00 constant DCMI_DCMI_ESCR_LSC                               \ Line start delimiter code This byte specifies the code of the line start delimiter. The code consists of 4 bytes in the form of 0xFF, 0x00, 0x00, LSC.
$00ff0000 constant DCMI_DCMI_ESCR_LEC                               \ Line end delimiter code This byte specifies the code of the line end delimiter. The code consists of 4 bytes in the form of 0xFF, 0x00, 0x00, LEC.
$ff000000 constant DCMI_DCMI_ESCR_FEC                               \ Frame end delimiter code This byte specifies the code of the frame end delimiter. The code consists of 4 bytes in the form of 0xFF, 0x00, 0x00, FEC. If FEC is programmed to 0xFF, all the unused codes (0xFF0000XY) are interpreted as frame end delimiters.


\
\ @brief DCMI embedded synchronization unmask register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DCMI_DCMI_ESUR_FSU                               \ Frame start delimiter unmask This byte specifies the mask to be applied to the code of the frame start delimiter.
$0000ff00 constant DCMI_DCMI_ESUR_LSU                               \ Line start delimiter unmask This byte specifies the mask to be applied to the code of the line start delimiter.
$00ff0000 constant DCMI_DCMI_ESUR_LEU                               \ Line end delimiter unmask This byte specifies the mask to be applied to the code of the line end delimiter.
$ff000000 constant DCMI_DCMI_ESUR_FEU                               \ Frame end delimiter unmask This byte specifies the mask to be applied to the code of the frame end delimiter.


\
\ @brief DCMI crop window start
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00003fff constant DCMI_DCMI_CWSTRT_HOFFCNT                         \ Horizontal offset count This value gives the number of pixel clocks to count before starting a capture.
$1fff0000 constant DCMI_DCMI_CWSTRT_VST                             \ Vertical start line count The image capture starts with this line number. Previous line data are ignored. ....


\
\ @brief DCMI crop window size
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00003fff constant DCMI_DCMI_CWSIZE_CAPCNT                          \ Capture count This value gives the number of pixel clocks to be captured from the starting point on the same line. It value must corresponds to word-aligned data for different widths of parallel interfaces. 0x0000 = 1 pixel 0x0001 = 2 pixels 0x0002 = 3 pixels ....
$3fff0000 constant DCMI_DCMI_CWSIZE_VLINE                           \ Vertical line count This value gives the number of lines to be captured from the starting point. ....


\
\ @brief DCMI data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DCMI_DCMI_DR_BYTE0                               \ Data byte 0
$0000ff00 constant DCMI_DCMI_DR_BYTE1                               \ Data byte 1
$00ff0000 constant DCMI_DCMI_DR_BYTE2                               \ Data byte 2
$ff000000 constant DCMI_DCMI_DR_BYTE3                               \ Data byte 3


\
\ @brief Digital camera interface
\
$4202c000 constant DCMI_DCMI_CR   \ offset: 0x00 : DCMI control register
$4202c004 constant DCMI_DCMI_SR   \ offset: 0x04 : DCMI status register
$4202c008 constant DCMI_DCMI_RIS  \ offset: 0x08 : DCMI raw interrupt status register
$4202c00c constant DCMI_DCMI_IER  \ offset: 0x0C : DCMI interrupt enable register
$4202c010 constant DCMI_DCMI_MIS  \ offset: 0x10 : DCMI masked interrupt status register
$4202c014 constant DCMI_DCMI_ICR  \ offset: 0x14 : DCMI interrupt clear register
$4202c018 constant DCMI_DCMI_ESCR  \ offset: 0x18 : DCMI embedded synchronization code register
$4202c01c constant DCMI_DCMI_ESUR  \ offset: 0x1C : DCMI embedded synchronization unmask register
$4202c020 constant DCMI_DCMI_CWSTRT  \ offset: 0x20 : DCMI crop window start
$4202c024 constant DCMI_DCMI_CWSIZE  \ offset: 0x24 : DCMI crop window size
$4202c028 constant DCMI_DCMI_DR   \ offset: 0x28 : DCMI data register

