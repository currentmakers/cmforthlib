\
\ @file tsc.fs
\ @brief Touch sensing controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TSC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_CR_TSCE                                  \ Touch sensing controller enable This bit is set and cleared by software to enable/disable the touch sensing controller. Note: When the touch sensing controller is disabled, TSC registers settings have no effect.
$00000002 constant TSC_TSC_CR_START                                 \ Start a new acquisition This bit is set by software to start a new acquisition. It is cleared by hardware as soon as the acquisition is complete or by software to cancel the ongoing acquisition.
$00000004 constant TSC_TSC_CR_AM                                    \ Acquisition mode This bit is set and cleared by software to select the acquisition mode. Note: This bit must not be modified when an acquisition is ongoing.
$00000008 constant TSC_TSC_CR_SYNCPOL                               \ Synchronization pin polarity This bit is set and cleared by software to select the polarity of the synchronization input pin.
$00000010 constant TSC_TSC_CR_IODEF                                 \ I/O Default mode This bit is set and cleared by software. It defines the configuration of all the TSC I/Os when there is no ongoing acquisition. When there is an ongoing acquisition, it defines the configuration of all unused I/Os (not defined as sampling capacitor I/O or as channel I/O). Note: This bit must not be modified when an acquisition is ongoing.
$000000e0 constant TSC_TSC_CR_MCV                                   \ Max count value These bits are set and cleared by software. They define the maximum number of charge transfer pulses that can be generated before a max count error is generated. Note: These bits must not be modified when an acquisition is ongoing.
$00007000 constant TSC_TSC_CR_PGPSC                                 \ Pulse generator prescaler These bits are set and cleared by software.They select the AHB clock divider used to generate the pulse generator clock (PGCLK). Note: These bits must not be modified when an acquisition is ongoing. Note: Some configurations are forbidden. Refer to the Section21.3.4: Charge transfer acquisition sequence for details.
$00008000 constant TSC_TSC_CR_SSPSC                                 \ Spread spectrum prescaler This bit is set and cleared by software. It selects the AHB clock divider used to generate the spread spectrum clock (SSCLK). Note: This bit must not be modified when an acquisition is ongoing.
$00010000 constant TSC_TSC_CR_SSE                                   \ Spread spectrum enable This bit is set and cleared by software to enable/disable the spread spectrum feature. Note: This bit must not be modified when an acquisition is ongoing.
$00fe0000 constant TSC_TSC_CR_SSD                                   \ Spread spectrum deviation These bits are set and cleared by software. They define the spread spectrum deviation which consists in adding a variable number of periods of the SSCLK clock to the charge transfer pulse high state. ... Note: These bits must not be modified when an acquisition is ongoing.
$0f000000 constant TSC_TSC_CR_CTPL                                  \ Charge transfer pulse low These bits are set and cleared by software. They define the duration of the low state of the charge transfer pulse (transfer of charge from CsubX/sub to CsubS/sub). ... Note: These bits must not be modified when an acquisition is ongoing. Note: Some configurations are forbidden. Refer to the Section21.3.4: Charge transfer acquisition sequence for details.
$f0000000 constant TSC_TSC_CR_CTPH                                  \ Charge transfer pulse high These bits are set and cleared by software. They define the duration of the high state of the charge transfer pulse (charge of CsubX/sub). ... Note: These bits must not be modified when an acquisition is ongoing.


\
\ @brief TSC interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IER_EOAIE                                \ End of acquisition interrupt enable This bit is set and cleared by software to enable/disable the end of acquisition interrupt.
$00000002 constant TSC_TSC_IER_MCEIE                                \ Max count error interrupt enable This bit is set and cleared by software to enable/disable the max count error interrupt.


\
\ @brief TSC interrupt clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_ICR_EOAIC                                \ End of acquisition interrupt clear This bit is set by software to clear the end of acquisition flag and it is cleared by hardware when the flag is reset. Writing a '0' has no effect.
$00000002 constant TSC_TSC_ICR_MCEIC                                \ Max count error interrupt clear This bit is set by software to clear the max count error flag and it is cleared by hardware when the flag is reset. Writing a '0' has no effect.


\
\ @brief TSC interrupt status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_ISR_EOAF                                 \ End of acquisition flag This bit is set by hardware when the acquisition of all enabled group is complete (all GxS bits of all enabled analog I/O groups are set or when a max count error is detected). It is cleared by software writing 1 to the bit EOAIC of the TSC_ICR register.
$00000002 constant TSC_TSC_ISR_MCEF                                 \ Max count error flag This bit is set by hardware as soon as an analog I/O group counter reaches the max count value specified. It is cleared by software writing 1 to the bit MCEIC of the TSC_ICR register.


\
\ @brief TSC I/O hysteresis control register
\ Address offset: 0x10
\ Reset value: 0xFFFFFFFF
\

$00000001 constant TSC_TSC_IOHCR_G1_IO1                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000002 constant TSC_TSC_IOHCR_G1_IO2                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000004 constant TSC_TSC_IOHCR_G1_IO3                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000008 constant TSC_TSC_IOHCR_G1_IO4                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000010 constant TSC_TSC_IOHCR_G2_IO1                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000020 constant TSC_TSC_IOHCR_G2_IO2                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000040 constant TSC_TSC_IOHCR_G2_IO3                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000080 constant TSC_TSC_IOHCR_G2_IO4                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000100 constant TSC_TSC_IOHCR_G3_IO1                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000200 constant TSC_TSC_IOHCR_G3_IO2                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000400 constant TSC_TSC_IOHCR_G3_IO3                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000800 constant TSC_TSC_IOHCR_G3_IO4                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00001000 constant TSC_TSC_IOHCR_G4_IO1                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00002000 constant TSC_TSC_IOHCR_G4_IO2                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00004000 constant TSC_TSC_IOHCR_G4_IO3                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00008000 constant TSC_TSC_IOHCR_G4_IO4                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00010000 constant TSC_TSC_IOHCR_G5_IO1                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00020000 constant TSC_TSC_IOHCR_G5_IO2                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00040000 constant TSC_TSC_IOHCR_G5_IO3                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00080000 constant TSC_TSC_IOHCR_G5_IO4                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00100000 constant TSC_TSC_IOHCR_G6_IO1                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00200000 constant TSC_TSC_IOHCR_G6_IO2                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00400000 constant TSC_TSC_IOHCR_G6_IO3                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00800000 constant TSC_TSC_IOHCR_G6_IO4                             \ Gx_IOy Schmitt trigger hysteresis mode, x = 8 to 1, y = 4 to 1. These bits are set and cleared by software to enable/disable the Gx_IOy Schmitt trigger hysteresis. Note: These bits control the I/O Schmitt trigger hysteresis whatever the I/O control mode is (even if controlled by standard GPIO registers).


\
\ @brief TSC I/O analog switch control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IOASCR_G1_IO1                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000002 constant TSC_TSC_IOASCR_G1_IO2                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000004 constant TSC_TSC_IOASCR_G1_IO3                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000008 constant TSC_TSC_IOASCR_G1_IO4                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000010 constant TSC_TSC_IOASCR_G2_IO1                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000020 constant TSC_TSC_IOASCR_G2_IO2                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000040 constant TSC_TSC_IOASCR_G2_IO3                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000080 constant TSC_TSC_IOASCR_G2_IO4                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000100 constant TSC_TSC_IOASCR_G3_IO1                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000200 constant TSC_TSC_IOASCR_G3_IO2                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000400 constant TSC_TSC_IOASCR_G3_IO3                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00000800 constant TSC_TSC_IOASCR_G3_IO4                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00001000 constant TSC_TSC_IOASCR_G4_IO1                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00002000 constant TSC_TSC_IOASCR_G4_IO2                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00004000 constant TSC_TSC_IOASCR_G4_IO3                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00008000 constant TSC_TSC_IOASCR_G4_IO4                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00010000 constant TSC_TSC_IOASCR_G5_IO1                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00020000 constant TSC_TSC_IOASCR_G5_IO2                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00040000 constant TSC_TSC_IOASCR_G5_IO3                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00080000 constant TSC_TSC_IOASCR_G5_IO4                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00100000 constant TSC_TSC_IOASCR_G6_IO1                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00200000 constant TSC_TSC_IOASCR_G6_IO2                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00400000 constant TSC_TSC_IOASCR_G6_IO3                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).
$00800000 constant TSC_TSC_IOASCR_G6_IO4                            \ Gx_IOy analog switch enable These bits are set and cleared by software to enable/disable the Gx_IOy analog switch. Note: These bits control the I/O analog switch whatever the I/O control mode is (even if controlled by standard GPIO registers).


\
\ @brief TSC I/O sampling control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IOSCR_G1_IO1                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000002 constant TSC_TSC_IOSCR_G1_IO2                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000004 constant TSC_TSC_IOSCR_G1_IO3                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000008 constant TSC_TSC_IOSCR_G1_IO4                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000010 constant TSC_TSC_IOSCR_G2_IO1                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000020 constant TSC_TSC_IOSCR_G2_IO2                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000040 constant TSC_TSC_IOSCR_G2_IO3                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000080 constant TSC_TSC_IOSCR_G2_IO4                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000100 constant TSC_TSC_IOSCR_G3_IO1                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000200 constant TSC_TSC_IOSCR_G3_IO2                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000400 constant TSC_TSC_IOSCR_G3_IO3                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000800 constant TSC_TSC_IOSCR_G3_IO4                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00001000 constant TSC_TSC_IOSCR_G4_IO1                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00002000 constant TSC_TSC_IOSCR_G4_IO2                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00004000 constant TSC_TSC_IOSCR_G4_IO3                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00008000 constant TSC_TSC_IOSCR_G4_IO4                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00010000 constant TSC_TSC_IOSCR_G5_IO1                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00020000 constant TSC_TSC_IOSCR_G5_IO2                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00040000 constant TSC_TSC_IOSCR_G5_IO3                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00080000 constant TSC_TSC_IOSCR_G5_IO4                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00100000 constant TSC_TSC_IOSCR_G6_IO1                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00200000 constant TSC_TSC_IOSCR_G6_IO2                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00400000 constant TSC_TSC_IOSCR_G6_IO3                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00800000 constant TSC_TSC_IOSCR_G6_IO4                             \ Gx_IOy sampling mode These bits are set and cleared by software to configure the Gx_IOy as a sampling capacitor I/O. Only one I/O per analog I/O group must be defined as sampling capacitor. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOSCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.


\
\ @brief TSC I/O channel control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IOCCR_G1_IO1                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000002 constant TSC_TSC_IOCCR_G1_IO2                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000004 constant TSC_TSC_IOCCR_G1_IO3                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000008 constant TSC_TSC_IOCCR_G1_IO4                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000010 constant TSC_TSC_IOCCR_G2_IO1                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000020 constant TSC_TSC_IOCCR_G2_IO2                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000040 constant TSC_TSC_IOCCR_G2_IO3                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000080 constant TSC_TSC_IOCCR_G2_IO4                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000100 constant TSC_TSC_IOCCR_G3_IO1                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000200 constant TSC_TSC_IOCCR_G3_IO2                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000400 constant TSC_TSC_IOCCR_G3_IO3                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00000800 constant TSC_TSC_IOCCR_G3_IO4                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00001000 constant TSC_TSC_IOCCR_G4_IO1                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00002000 constant TSC_TSC_IOCCR_G4_IO2                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00004000 constant TSC_TSC_IOCCR_G4_IO3                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00008000 constant TSC_TSC_IOCCR_G4_IO4                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00010000 constant TSC_TSC_IOCCR_G5_IO1                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00020000 constant TSC_TSC_IOCCR_G5_IO2                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00040000 constant TSC_TSC_IOCCR_G5_IO3                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00080000 constant TSC_TSC_IOCCR_G5_IO4                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00100000 constant TSC_TSC_IOCCR_G6_IO1                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00200000 constant TSC_TSC_IOCCR_G6_IO2                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00400000 constant TSC_TSC_IOCCR_G6_IO3                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.
$00800000 constant TSC_TSC_IOCCR_G6_IO4                             \ Gx_IOy channel mode These bits are set and cleared by software to configure the Gx_IOy as a channel I/O. Note: These bits must not be modified when an acquisition is ongoing. Note: During the acquisition phase and even if the TSC peripheral alternate function is not enabled, as soon as the TSC_IOCCR bit is set, the corresponding GPIO analog switch is automatically controlled by the touch sensing controller.


\
\ @brief TSC I/O group control status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TSC_TSC_IOGCSR_G1E                               \ Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
$00000002 constant TSC_TSC_IOGCSR_G2E                               \ Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
$00000004 constant TSC_TSC_IOGCSR_G3E                               \ Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
$00000008 constant TSC_TSC_IOGCSR_G4E                               \ Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
$00000010 constant TSC_TSC_IOGCSR_G5E                               \ Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
$00000020 constant TSC_TSC_IOGCSR_G6E                               \ Analog I/O group x enable These bits are set and cleared by software to enable/disable the acquisition (counter is counting) on the corresponding analog I/O group x.
$00010000 constant TSC_TSC_IOGCSR_G1S                               \ Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
$00020000 constant TSC_TSC_IOGCSR_G2S                               \ Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
$00040000 constant TSC_TSC_IOGCSR_G3S                               \ Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
$00080000 constant TSC_TSC_IOGCSR_G4S                               \ Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
$00100000 constant TSC_TSC_IOGCSR_G5S                               \ Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.
$00200000 constant TSC_TSC_IOGCSR_G6S                               \ Analog I/O group x status These bits are set by hardware when the acquisition on the corresponding enabled analog I/O group x is complete. They are cleared by hardware when a new acquisition is started. Note: When a max count error is detected the remaining GxS bits of the enabled analog I/O groups are not set.


\
\ @brief TSC I/O group 1 counter register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG1CR_CNT                               \ Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).


\
\ @brief TSC I/O group 2 counter register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG2CR_CNT                               \ Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).


\
\ @brief TSC I/O group 3 counter register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG3CR_CNT                               \ Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).


\
\ @brief TSC I/O group 4 counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG4CR_CNT                               \ Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).


\
\ @brief TSC I/O group 5 counter register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG5CR_CNT                               \ Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).


\
\ @brief TSC I/O group 6 counter register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00003fff constant TSC_TSC_IOG6CR_CNT                               \ Counter value These bits represent the number of charge transfer cycles generated on the analog I/O group x to complete its acquisition (voltage across CsubS/sub has reached the threshold).


\
\ @brief Touch sensing controller
\
$40024000 constant TSC_TSC_CR     \ offset: 0x00 : TSC control register
$40024004 constant TSC_TSC_IER    \ offset: 0x04 : TSC interrupt enable register
$40024008 constant TSC_TSC_ICR    \ offset: 0x08 : TSC interrupt clear register
$4002400c constant TSC_TSC_ISR    \ offset: 0x0C : TSC interrupt status register
$40024010 constant TSC_TSC_IOHCR  \ offset: 0x10 : TSC I/O hysteresis control register
$40024018 constant TSC_TSC_IOASCR  \ offset: 0x18 : TSC I/O analog switch control register
$40024020 constant TSC_TSC_IOSCR  \ offset: 0x20 : TSC I/O sampling control register
$40024028 constant TSC_TSC_IOCCR  \ offset: 0x28 : TSC I/O channel control register
$40024030 constant TSC_TSC_IOGCSR  \ offset: 0x30 : TSC I/O group control status register
$40024034 constant TSC_TSC_IOG1CR  \ offset: 0x34 : TSC I/O group 1 counter register
$40024038 constant TSC_TSC_IOG2CR  \ offset: 0x38 : TSC I/O group 2 counter register
$4002403c constant TSC_TSC_IOG3CR  \ offset: 0x3C : TSC I/O group 3 counter register
$40024040 constant TSC_TSC_IOG4CR  \ offset: 0x40 : TSC I/O group 4 counter register
$40024044 constant TSC_TSC_IOG5CR  \ offset: 0x44 : TSC I/O group 5 counter register
$40024048 constant TSC_TSC_IOG6CR  \ offset: 0x48 : TSC I/O group 6 counter register

